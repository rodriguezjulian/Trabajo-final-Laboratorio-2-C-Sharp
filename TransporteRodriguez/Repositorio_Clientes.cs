using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TransporteRodriguez
{
    public class Repositorio_Clientes : Repositorio_Padre
    {
        private static List<Cliente> listaClientes = new List<Cliente>();
        private readonly static Repositorio_Clientes repo_Clientes = new Repositorio_Clientes();
        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }

        public static Repositorio_Clientes Repo_Clientes => repo_Clientes;
      /// <summary>
      /// Hardcodeo de Clientes
      /// </summary>
        public override void Agregar()
        {
            if (ListaClientes.Count == 0)
            {
                ListaClientes.Add(new Cliente("Juan Pérez", "juan123", "juan.perez@gmail.com", true, 1, "Av. Belgrano 1234", "Libros"));
                ListaClientes.Add(new Cliente("María García", "maria456", "maria.garcia@hotmail.com", true, 2, "Calle 25 de Mayo 5678", "Electrodomésticos"));
                ListaClientes.Add(new Cliente("Lucas Martínez", "lucas789", "lucas.martinez@yahoo.com", true, 3, "Av. Corrientes 2468", "Muebles"));
                ListaClientes.Add(new Cliente("Ana Rodríguez", "ana000", "ana.rodriguez@gmail.com", true, 4, "Calle Florida 4321", "Ropa"));
                ListaClientes.Add(new Cliente("Pedro González", "pedro111", "pedro.gonzalez@hotmail.com", true, 5, "Calle Reconquista 6789", "Juguetes"));
                ListaClientes.Add(new Cliente("Laura Fernández", "laura222", "laura.fernandez@yahoo.com", true, 6, "Av. Santa Fe 2468", "Calzado"));
                ListaClientes.Add(new Cliente("Javier Díaz", "javier333", "javier.diaz@gmail.com", true, 7, "Calle Maipú 3456", "Hogar"));
                ListaClientes.Add(new Cliente("Carla Castro", "carla444", "carla.castro@hotmail.com", true, 8, "Calle Lavalle 6789", "Mascotas"));
                ListaClientes.Add(new Cliente("Martín Suárez", "martin555", "martin.suarez@yahoo.com", true, 9, "Av. San Martín 1234", "Computación"));
                ListaClientes.Add(new Cliente("Silvia López", "silvia666", "silvia.lopez@gmail.com", true, 10, "Calle Esmeralda 5678", "Computación"));
                ListaClientes.Add(new Cliente("Federico Torres", "federico777", "federico.torres@hotmail.com", true, 11, "Av. Pueyrredón 2468", "Computación"));
                ListaClientes.Add(new Cliente("Valeria Gómez", "valeria888", "valeria.gomez@yahoo.com", true, 12, "Calle Callao 4321", "Computación"));
                ListaClientes.Add(new Cliente("Pablo Ramírez", "pablo999", "pablo.ramirez@gmail.com", true, 13, "Av. Córdoba 6789", "Computación"));
                ListaClientes.Add(new Cliente("Romina Acosta", "romina123", "romina.acosta@hotmail.com", true, 14, "Calle Mendoza 3456", "Computación"));
            }
        }
        /// <summary>
        /// Calcular el id de un nuevo cliente  segun el ultimo 
        /// </summary>
        /// <returns></returns>
        public override int CalcularId()
        {
            int retorno;
            Cliente clienteUltimo = ListaClientes[ListaClientes.Count - 1];
            retorno = (clienteUltimo.IdCliente) + 1;
            return retorno;
        }
        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public override Cliente BuscarInstanciaId(int idCliente)
        {
            Cliente cliente = null;
            foreach (Cliente clienteAuxliar in ListaClientes)
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
        public override Cliente BuscarInstancia(object usuarioUno)
        {
            Cliente retorno = null;
            if (usuarioUno is Cliente)
            {
                foreach (Cliente cliente in ListaClientes)
                {
                    if (cliente == usuarioUno)
                    {
                        retorno = cliente;
                        break;
                    }
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
            
            if (Validaciones.VerificarNombre(nombre) && !string.IsNullOrEmpty(direccion) && Sistema.CrearMail(mail, tipoMail,out mailFinal))
            {
                 ListaClientes.Add(new Cliente(nombre, Sistema.generarContraseña(), mailFinal, true,
                 CalcularId(), direccion, rubro));
                retorno = true;
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
        public bool ModificarCliente(int id,string nombre, string mail, string tipoMail, string direccion, string rubro, out Cliente clienteOut)
        {
            bool retorno=false;
            string mailFinal;
            clienteOut = null;
            if (Validaciones.VerificarNombre(nombre) && !string.IsNullOrEmpty(direccion) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
            {
                Cliente cliente = BuscarInstanciaId(id);
                clienteOut = cliente;
                cliente.Nombre = nombre;
                cliente.Rubro=rubro;
                cliente.Mail = mailFinal;
                cliente.DireccionBSAS = direccion;
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Baja logica del cliente apoyada por BuscarInstanciaId
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public override Cliente DarDeBaja(int ID)
        {
            Cliente cliente =BuscarInstanciaId(ID);
            if (cliente.Estado == true)
            {
                cliente.Estado = false;
            }
            return cliente;
        }

    }
}
