using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion_FireBase;

namespace TransporteRodriguez
{
    public class Repositorio_Empleados : Interfaz_Padre<Empleado>, Interfaz_Busqueda<Empleado,Usuario>
    {
        private static List<Empleado> listaEmpleado = new List<Empleado>();
        private readonly static Repositorio_Empleados repo_Empleados = new Repositorio_Empleados();
        public static List<Empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }

        public static Repositorio_Empleados Repo_Empleados => repo_Empleados;

        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>Se obtiene la direccion de memoria de la instancia a travez de su id
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public Empleado BuscarInstanciaId(int idEmpleado)
        {
            List<Empleado> listaEmpleados = Conexion_SQL.ObtenerEmpleados("empleados");
            Empleado empleado = null;
            foreach (Empleado empleadoAuxiliar in listaEmpleados)
            {
                if (empleadoAuxiliar.IdEmpleado == idEmpleado)
                {
                    empleado = empleadoAuxiliar;
                    break;
                }
            }
            return empleado;
        }

        /// <summary>
        ///  Buscar instancia utilizando una sobre carga en el ==
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <returns></returns>
        public Empleado BuscarInstancia(Usuario usuarioUno)
        {
            List<Empleado> ListaEmpleados = Conexion_SQL.ObtenerEmpleados("empleados");
            Empleado retorno = null;
            foreach (Empleado empleado in ListaEmpleados)
            {
                if (empleado == usuarioUno && empleado.Estado == true)
                {
                    retorno = empleado;
                    break;
                }
            }
            return retorno;
        }
        public bool VerificarPuesto(Empleado empleado)
        {
            bool retorno = false;

            if (empleado.Puesto == Puestos.Sistemas)
            {
                retorno = true;
            }
            else
            {
                throw new Exception("Solo los empleados del sector sistemas pueden acceder a esta opcion");
            }
            return retorno;
        }
        public Empleado DarDeBaja(string ID, Empleado empleadoLogueado)
        {
            Empleado empleado = null;
            int idEntero;
            if (Validaciones.VerificarIdIngresado(ID, out idEntero))
            {
                empleado = BuscarInstanciaId(idEntero);
                if (empleado is null)
                {
                    throw new Exception("Empleado no encontrado");
                }
                else
                {
                    if (empleadoLogueado == empleado)
                    {
                        throw new Exception("ERROR, No se puede eliminar asi mismo");

                    }
                    else
                    {
                        if (empleado.Estado == false)
                        {
                            throw new Exception("El empleado con ese ID ya se encontraba dado de baja");
                        }
                        else
                        {
                            Conexion_SQL.DarDeBaja(idEntero, "empleados", empleado);
                        }
                    }
                }
            }
            return empleado;
        }
        public async Task<bool> CrearEmpleado(string nombre, string mail, string tipoMail, Puestos puesto)
        {
            string mailFinal;
            bool retorno = false;
       
            if (VerificarPuesto(puesto))
            {
                if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                {
                    Empleado empleado = new Empleado(nombre, Sistema.generarContraseña(), mailFinal, true, puesto);
                    Conexion_SQL.Insertar(empleado, "empleados");
                    await Conexion_FireBase.Agregar(empleado, "2");
                    retorno = true;
                }
            }
            else
            {
                throw new Exception("ERROR, Ingrese puesto valido.");
            }
            return retorno;
        }
        /// <summary>
        /// Se realizaran las mismas verificaciones que al crear la instancia y nos apoyaremos de BuscarInstanciaId para afectar directamente
        /// a esa misma instancia
        /// </summary>
        /// <param name="id"></param>segun empleado elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - NO se modifica
        /// <param name="nombre"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="mail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="tipoMail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="puesto"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <returns></returns>
        /// 
        public bool VerificarPuesto(Puestos puesto)
        {
            bool retorno = false;   
            string puestoAux = puesto.ToString();
            
            List<String> puestos = Conexion_SQL.ObtenerPuestos("puestos");
            foreach (string p in puestos)
            {
                if (puestoAux == p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public bool ModificarEmpleado(string id,string nombre, string mail, string tipoMail, Puestos puesto)
         {
             string mailFinal;
             bool retorno = false;
             int idEntero;
            Empleado empleado = null;

            if (Validaciones.VerificarIdIngresado(id, out idEntero))
            {
                empleado = BuscarInstanciaId(idEntero);
                if (empleado is null)
                {
                    throw new Exception("Empleado no encontrado");
                }
                else
                {
                    if (VerificarPuesto(puesto))
                    {
                        if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                        {
                            retorno = true;
                            empleado.Nombre = nombre;
                            empleado.Puesto = puesto;
                            empleado.Mail = mailFinal;
                            Conexion_SQL.Modificar(empleado, "empleados");
                        }
                    }
                    else
                    {
                        throw new Exception("ERROR, Ingrese puesto valido.");
                    }
                }
            }
             return retorno;
         }
        /*public int OrdenarPorNombre (Empleado uno,Empleado dos)
        {
            return uno.Nombre.CompareTo(dos.Nombre);
        }*/
        public bool FiltrarEstados(Empleado uno,bool estadoFiltrado)
        {
            bool retorno=false;
            if (uno.Estado==estadoFiltrado)
            {
                return true;
            }
            return retorno;
        }
       /* public void TraerEmpleado(Empleado empleadoIns, out Empleado empleado)
        {
            empleado = empleadoIns;
        }*/
    }
}