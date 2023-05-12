using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Sistema
    {
        private static List<Cliente> listaClientes = new List<Cliente>();
        private static List<Empleado> listaEmpleado = new List<Empleado>();
        private static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private static List<Viaje> listaViajes = new List<Viaje>();
        public static List<Vehiculo> ListaVehiculos { get => listaVehiculos; set => listaVehiculos = value; }
        public static List<Viaje> ListaViajes { get => listaViajes; set => listaViajes = value; }
        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }

        static Sistema()
        {
            AgregarViajes();
            AgregarVehiculos();
        }
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
        public static void AgregarEmpleado()
        {
            listaEmpleado.Add(new Empleado("Usuario", "Contraseña", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
            listaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
            listaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", true, 2, "Analista de Sistemas"));
            listaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", true, 3, "Asistente Administrativo"));
            listaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", true, 4, "Desarrollador Web"));
            listaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", true, 5, "Contador General"));
        }
        private static void AgregarAdmin()
        {

        }
        public static void AgregarVehiculos()
        {
            listaVehiculos.Add(new Vehiculo(1, Marcas.Fiat, 1000, Colores.Rojo, "ABC123"));
            listaVehiculos.Add(new Vehiculo(2, Marcas.Scania, 1500, Colores.Gris, "DEF456"));
            listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "GHI789"));
            listaVehiculos.Add(new Vehiculo(4, Marcas.Volkswagen, 500, Colores.Azul, "JKL012"));
            listaVehiculos.Add(new Vehiculo(5, Marcas.Iveco, 1200, Colores.Blanco, "MNO345"));
        }

        public static void AgregarViajes()
        {
            Sistema.ListaViajes.Add(new Viaje(1, "María García", "Calle 25 de Mayo 5678",
            "Salta", 200, 10000, 1, DateTime.Parse("11/05/2025")));
            Sistema.ListaViajes.Add(new Viaje(2, "Javier Díaz", "Av. Córdoba 6789",
            "Corrientes", 1800, 10500, 5, DateTime.Parse("11/05/2024")));
            Sistema.ListaViajes.Add(new Viaje(3, "Laura Fernández", "Av. Santa Fe 2468",
           "Santa Fe", 20, 10500, 3, new DateTime(2024, 05, 11, 0, 0, 0)));
        }
        public static bool VerificarDisponibilidadFecha(Viaje viajeAxuliar)
        {
            bool retorno = true;
            foreach (Viaje viajesReservados in listaViajes)
            {
                if (viajesReservados == viajeAxuliar)
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        //Este metodo es clave para despues poder comparar la fecha ingresada con la existente
        public static DateTime ActualizarFechaIngresada(DateTime actual)
        {
            DateTime actualizado;
            actualizado = actual.Date;
            return actualizado;
        }
        public static short RetornarVehiculoDisponible(float kilos, DateTime fechaSolicitada)
        {
            float cargaSoportada;
            Viaje viajeAxuliar;
            //vehiculos aptos para transportar la cantidad de kilos.
            short retorno = 0;
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                cargaSoportada = vehiculo.CapacidadDeCarga;
                //busco 1 vehiculo que soporte el peso
                if (cargaSoportada >= kilos)
                {
                    //CREO UN VIAJE CON ESE VEHICULO EN ESA FECHA
                    viajeAxuliar = new(vehiculo.IdVehiculo, fechaSolicitada);
                    //SI YA HAY UN VIAJE CON ESA FECHA Y ESE IDVEHICULO, NO SE ROMPE EL BUCLE
                    //EN CASO QUE NO SEA POSIBLE ENCONTRAR UN VEHICULO DISPONIBLE RETORNO=0;
                    if (VerificarDisponibilidadFecha(viajeAxuliar))
                    {
                        retorno = vehiculo.IdVehiculo;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static float calcularPrecioViaje(int provincia, float kilosTransportados)
        {
            float precio = 0;
            switch (provincia)
            {
                case 0:
                    precio = (kilosTransportados * 200) + 4000;
                    break;
                case 1:
                    precio = (kilosTransportados * 200) + 6000;
                    break;
                case 2:
                    precio = (kilosTransportados * 200) + 8000;
                    break;
            }
            return precio;
        }
        public static bool buscarViaje(int idViaje, out Viaje? viajeEncontrado)
        {
            viajeEncontrado = null;
            bool retorno = false;

            foreach (Viaje viajeAxuliar in ListaViajes)
            {
                if (viajeAxuliar.IdViaje == idViaje)
                {
                    viajeEncontrado = viajeAxuliar;
                    retorno = true;
                    break;
                }

            }
            return retorno;
        }

        public static int CalcularIdViaje()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje) + 1;
            return retorno;
        }
        public static int CalcularIdCliente()
        {
            int retorno;
            Cliente clienteUltimo = ListaClientes[ListaClientes.Count - 1];
            retorno = (clienteUltimo.IdCliente) + 1;
            return retorno;
        }
        public static Usuario ValidarUsuario(Usuario usuarioUno)
        {
            Usuario? retorno = null;

            foreach (Empleado empleado in listaEmpleado)
            {
                if (empleado == usuarioUno && empleado.Estado == true)
                {
                    retorno = empleado;
                    break;
                }
            }
            if (retorno == null)
            {
                foreach (Cliente cliente in ListaClientes)
                {
                    if (cliente == usuarioUno && cliente.Estado == true)
                    {
                        retorno = cliente;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool ValidarUsuario(Empleado empleadoUno)
        {
            bool retorno = false;
            foreach (Empleado empleado in listaEmpleado)
            {
                if (empleadoUno == empleado)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool ValidarUsuario(Cliente empleadoUno)
        {
            bool retorno = false;
            foreach (Cliente empleado in ListaClientes)
            {
                if (empleadoUno == empleado)
                {
                    retorno = true;
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
        public static bool FiltrarClientes(List<Cliente> listaClientesBaja)
        {
             bool retorno = false;
           
            foreach (Cliente clienteAuxiliar in ListaClientes)
            {
                if(clienteAuxiliar.Estado==false)
                {
                    //ListaClientes.Add(new Cliente("Juan Pérez", "juan123", "juan.perez@gmail.com", true, 1, "Av. Belgrano 1234", "Libros"));
                    listaClientesBaja.Add(new Cliente(clienteAuxiliar.Nombre, clienteAuxiliar.Contraseña, clienteAuxiliar.Mail, clienteAuxiliar.Estado, 
                        clienteAuxiliar.IdCliente, clienteAuxiliar.DireccionBSAS, clienteAuxiliar.Rubro));
                        retorno =true;
                }
            }
            return retorno;
        }

}
}
