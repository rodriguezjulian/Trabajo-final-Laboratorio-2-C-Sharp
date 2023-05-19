using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Empleados : Repositorio_Padre
    {
        private static List<Empleado> listaEmpleado = new List<Empleado>();
        private readonly static Repositorio_Empleados repo_Empleados = new Repositorio_Empleados();
        public static List<Empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }

        public static Repositorio_Empleados Repo_Empleados => repo_Empleados;
        /// <summary>
        /// Hardcodeo de Empleados
        /// </summary>
        public override void Agregar()
        {
            if (ListaEmpleado.Count == 0)
            {
                ListaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", true, 1, Puestos.Ventas));
                ListaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", true, 2, Puestos.Sistemas));
                ListaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", true, 3, Puestos.Administracion));
                ListaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", true, 4, Puestos.Administracion));
                ListaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", true, 5, Puestos.Cobranzas));
            }
        }
        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>Se obtiene la direccion de memoria de la instancia a travez de su id
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public override Empleado BuscarInstanciaId(int idEmpleado)
        {
            Empleado empleado = null;
            foreach (Empleado empleadoAuxiliar in ListaEmpleado)
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
        /// Calcular el id de un nuevo cliente  segun el ultimo 
        /// </summary>
        /// <returns></returns>
        public override int CalcularId()
        {
            int retorno;
            Empleado ultimo = ListaEmpleado[ListaEmpleado.Count - 1];
            retorno = (ultimo.IdEmpleado) + 1;
            return retorno;
        }
        /// <summary>
        ///  Buscar instancia utilizando una sobre carga en el ==
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <returns></returns>
        public override Empleado BuscarInstancia(object usuarioUno)
        {
            Empleado retorno = null;
            if (usuarioUno is Empleado)
            {
                foreach (Empleado empleado in ListaEmpleado)
                {
                    if (empleado == usuarioUno)
                    {
                        retorno = empleado;
                        break;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Baja logica del cliente apoyada por BuscarInstanciaId
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public override Empleado DarDeBaja(int ID)
        {
            Empleado empleado = BuscarInstanciaId(ID);
            if (empleado.Estado == true)
            {
                empleado.Estado = false;
            }
            return empleado;
        }
        /// <summary>
        /// Se crea una nueva instancia apoyandonos con distintas funciones como son  VerificarNombre,CrearMail,generarContraseña,CalcularId para
        /// evitar errores de cualquier tipo
        /// </summary>
        /// <param name="nombre"></param>Ingresado por el usuario, no podra contener numero (VerificarNombre)
        /// <param name="mail"></param>Ingresado por el usuario, no podra contener @ (CrearMail)
        /// <param name="tipoMail"></param>Elegido desde un combo Box para evitar errores
        /// <param name="puesto"></param>Elegido desde un combo Box 
        /// <returns></returns>
        public bool CrearEmpleado(string nombre, string mail, string tipoMail, Puestos puesto)
        {
            string mailFinal;
            bool retorno = false;
            if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
            {
                ListaEmpleado.Add(new Empleado(nombre, Sistema.generarContraseña(), mailFinal, true, CalcularId(), puesto));

                retorno = true;
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
        public bool ModificarCliente(int id,string nombre, string mail, string tipoMail, Puestos puesto)
        {
            string mailFinal;
            bool retorno = false;
            if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
            {
                retorno=true;
                Empleado empleado = Repositorio_Empleados.Repo_Empleados.BuscarInstanciaId(id);
                empleado.Nombre = nombre;
                empleado.Puesto = puesto;
                empleado.Mail = mailFinal;
            }
            return retorno;
        }
    }
}