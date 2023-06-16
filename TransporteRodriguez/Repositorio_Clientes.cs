using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TransporteRodriguez
{
    public class Repositorio_Clientes : Interfaz_Padre <Cliente>,Interfaz_Busqueda<Cliente, Usuario>
    {
        private static List<Cliente> listaClientes = new List<Cliente>();
        private readonly static Repositorio_Clientes repo_Clientes = new Repositorio_Clientes();
        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        /*
                 private readonly static Repositorio_Empleados repo_Empleados = new Repositorio_Empleados();
        public static List<Empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }

        public static Repositorio_Empleados Repo_Empleados => repo_Empleados;
         */
        public static Repositorio_Clientes Repo_Clientes => repo_Clientes;




        public  Cliente BuscarInstanciaId(int idCliente)
        {
            Cliente cliente = null;
            List<Cliente> lista = Conexion_SQL.ObtenerClientes("clientes");
            foreach (Cliente clienteAuxliar in lista)
            {
                if (clienteAuxliar.IdCliente == idCliente)
                {

                    cliente = clienteAuxliar;
                    break;
                }
            }
            return cliente;
        }
        /// <summary>
        /// Buscar instancia utilizando una sobre carga en el ==
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <returns></returns>
        public Cliente BuscarInstancia(Usuario usuarioUno)
        {
            List<Cliente> ListaClientes = Conexion_SQL.ObtenerClientes("clientes");
            Cliente retorno = null;
            foreach (Cliente cliente in ListaClientes)
            {
                if (cliente == usuarioUno && cliente.Estado == true)
                {
                    retorno = cliente;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Se crea una nueva instancia apoyandonos con distintas funciones como son  VerificarNombre,CrearMail,generarContraseña,CalcularId para
        /// evitar errores de cualquier tipo.
        /// </summary>
        /// <param name="nombre"></param>Ingresado por el usuario, no podra contener numero (VerificarNombre)
        /// <param name="mail"></param>Ingresado por el usuario, no podra contener @ (CrearMail)
        /// <param name="tipoMail"></param>Elegido desde un combo Box para evitar errores
        /// <param name="direccion"></param>
        /// <param name="rubro"></param>Elegido desde un combo Box para encasillar categorias
        /// <returns></returns>
        public bool CrearCliente(string nombre, string mail,string tipoMail ,string direccion, string rubro)
        {
            string mailFinal;
            bool retorno = false;
            if (direccion == "")
            {
                throw new Exception("ERROR, Ingrese direccion del nuevo cliente");
            }
            else
            {
                if (rubro == "")
                {
                    throw new Exception("ERROR, Ingrese rubro del nuevo cliente");
                }
                else
                {
                    if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                    {
                        Cliente cliente = new Cliente(nombre, Sistema.generarContraseña(), mailFinal, true, direccion, rubro);
                        Conexion_SQL.Insertar(cliente, "clientes");
                        //ListaClientes.Add(new Cliente(nombre, Sistema.generarContraseña(), mailFinal, true,CalcularId(), direccion, rubro));
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Se realizaran las mismas verificaciones que al crear la instancia y nos apoyaremos de BuscarInstanciaId para afectar directamente
        /// a esa misma instancia
        /// </summary>
        /// <param name="id"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - NO se modifica
        /// <param name="nombre"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="mail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="tipoMail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro- MODIFICABLE
        /// <param name="direccion"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="rubro"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="clienteOut"></param> Se devuelve la instancia para mostrar con MessageBox.Show un resumen de los datos del cliente (stringBuilder)
        /// <returns></returns>
        public bool ModificarCliente(string ID,string nombre, string mail, string tipoMail, string direccion, string rubro, out Cliente clienteOut)
        {
            bool retorno=false;
            string mailFinal;
            clienteOut = null;
            int idEntero;
            Cliente cliente = null;
            if (Validaciones.VerificarIdIngresado(ID,out idEntero)) 
            {
                cliente = BuscarInstanciaId(idEntero);
                if (cliente is null)
                {
                    throw new Exception("Cliente no encontrado");
                }
                else 
                {
                    if (direccion == "")
                    {
                        throw new Exception("ERROR, Ingrese direccion del cliente");
                    }
                    else
                    {
                        if (rubro == "")
                        {
                            throw new Exception("ERROR, Ingrese rubro del cliente");
                        }
                        else
                        {
                            if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                            {
                                cliente.Nombre = nombre;
                                cliente.Rubro = rubro;
                                cliente.Mail = mailFinal;
                                cliente.DireccionBSAS = direccion;
                                clienteOut = cliente;
                                Conexion_SQL.Modificar(cliente, "clientes");
                                retorno = true;
                            }
                        }
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
        public  Cliente DarDeBaja(string ID)
        {
            int idEntero;
            Cliente cliente = null;

            if (Validaciones.VerificarIdIngresado(ID, out idEntero))
            {
                cliente = BuscarInstanciaId(idEntero);
                if (cliente is null)
                {
                    throw new Exception("Cliente no encontrado");
                }
                else
                {
                    if (cliente.Estado == false)
                    {
                        throw new Exception("El empleado con ese ID ya se encontraba dado de baja");
                    }
                    else
                    {
                        Conexion_SQL.DarDeBaja(idEntero, "clientes", cliente);
                    }
                }
            }
            return cliente;
        }
    }
}
