using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Repositorio_Clientes 
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }

      // public static void AgregarCliente()
       public static void AgregarCliente()
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
        public static int CalcularIdCliente()
        {
            int retorno;
            Cliente clienteUltimo = ListaClientes[ListaClientes.Count - 1];
            retorno = (clienteUltimo.IdCliente) + 1;
            return retorno;
        }
      /*  public static bool FiltrarClientes(List<Cliente> listaClientesBaja)
        {
            bool retorno = false;

            foreach (Cliente clienteAuxiliar in ListaClientes)
            {
                if (clienteAuxiliar.Estado == false)
                {
                    //ListaClientes.Add(new Cliente("Juan Pérez", "juan123", "juan.perez@gmail.com", true, 1, "Av. Belgrano 1234", "Libros"));
                    listaClientesBaja.Add(new Cliente(clienteAuxiliar.Nombre, clienteAuxiliar.Contraseña, clienteAuxiliar.Mail, clienteAuxiliar.Estado,
                        clienteAuxiliar.IdCliente, clienteAuxiliar.DireccionBSAS, clienteAuxiliar.Rubro));
                    retorno = true;
                }
            }
            return retorno;
        }*/
        public static Cliente BuscarCliente(Usuario usuarioUno)
        {
            Cliente? retorno = null;
            foreach (Cliente cliente in ListaClientes)
            {
                if (cliente == usuarioUno)
                {
                    retorno = cliente;
                    break;
                }
            }
            return retorno;
        }
        public static Cliente BuscarCliente(int idCliente)
        {
            Cliente cliente = null;
            //int contador = 0;
            foreach (Cliente clienteAuxliar in listaClientes)
            {
                if (clienteAuxliar.IdCliente == idCliente)
                {

                    cliente = clienteAuxliar;
                    break;
                }
                // contador = contador + 1;
            }
            //indice = contador;
            return cliente;
        }
    }
}
