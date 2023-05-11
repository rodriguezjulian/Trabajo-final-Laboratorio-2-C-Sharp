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
        static Sistema()
        {
            AgregarViajes();
            AgregarVehiculos();
        }
        public static void AgregarCliente()
        {
            listaClientes.Add(new Cliente("Juan Pérez", "juan123", "juan.perez@gmail.com", 1,1, "Av. Belgrano 1234", "Libros"));
            listaClientes.Add(new Cliente("María García", "maria456", "maria.garcia@hotmail.com", 1,2, "Calle 25 de Mayo 5678", "Electrodomésticos"));
            listaClientes.Add(new Cliente("Lucas Martínez", "lucas789", "lucas.martinez@yahoo.com", 1, 3, "Av. Corrientes 2468", "Muebles"));
            listaClientes.Add(new Cliente("Ana Rodríguez", "ana000", "ana.rodriguez@gmail.com", 1, 4, "Calle Florida 4321", "Ropa"));
            listaClientes.Add(new Cliente("Pedro González", "pedro111", "pedro.gonzalez@hotmail.com", 1, 5, "Calle Reconquista 6789", "Juguetes"));
            listaClientes.Add(new Cliente("Laura Fernández", "laura222", "laura.fernandez@yahoo.com", 1, 6, "Av. Santa Fe 2468", "Calzado"));
            listaClientes.Add(new Cliente("Javier Díaz", "javier333", "javier.diaz@gmail.com",1, 7, "Calle Maipú 3456", "Hogar"));
            listaClientes.Add(new Cliente("Carla Castro", "carla444", "carla.castro@hotmail.com",1, 8, "Calle Lavalle 6789", "Mascotas"));
            listaClientes.Add(new Cliente("Martín Suárez", "martin555", "martin.suarez@yahoo.com", 1, 9, "Av. San Martín 1234", "Computación"));
            listaClientes.Add(new Cliente("Silvia López", "silvia666", "silvia.lopez@gmail.com", 1, 10, "Calle Esmeralda 5678", "Computación"));
            listaClientes.Add(new Cliente("Federico Torres", "federico777", "federico.torres@hotmail.com",1, 11, "Av. Pueyrredón 2468", "Computación"));
            listaClientes.Add(new Cliente("Valeria Gómez", "valeria888", "valeria.gomez@yahoo.com",1, 12, "Calle Callao 4321", "Computación"));
            listaClientes.Add(new Cliente("Pablo Ramírez", "pablo999", "pablo.ramirez@gmail.com", 1, 13, "Av. Córdoba 6789", "Computación"));
            listaClientes.Add(new Cliente("Romina Acosta", "romina123", "romina.acosta@hotmail.com", 1, 14, "Calle Mendoza 3456", "Computación"));
        }
        public static void AgregarEmpleado()
        {
            listaEmpleado.Add(new Empleado("Usuario", "Contraseña", "juan.perez@gmail.com", 1,1, "Gerente de Ventas"));
            listaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com",1, 1, "Gerente de Ventas"));
            listaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com",1, 2, "Analista de Sistemas"));
            listaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", 1, 3, "Asistente Administrativo"));
            listaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", 1, 4, "Desarrollador Web"));
            listaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com",1, 5, "Contador General"));
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
            "Corrientes", 500, 10500, 5, DateTime.Parse("11/05/2024")));
            Sistema.ListaViajes.Add(new Viaje(3, "Laura Fernández", "Av. Santa Fe 2468",
           "Santa Fe", 1400, 10500, 3, DateTime.Parse("11/05/2024")));
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
       
        public static short RetornarVehiculoDisponible(float kilos, DateTime fechaSolicitada)
        {
            float cargaSoportada;
            Viaje viajeAxuliar;
            //vehiculos aptos para transportar la cantidad de kilos.
            short retorno =0;
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                cargaSoportada = vehiculo.CapacidadDeCarga;
                //busco 1 vehiculo que soporte el peso
                if (cargaSoportada >= kilos)
                {
                    //CREO UN VIAJE CON ESE VEHICULO EN ESA FECHA
                    viajeAxuliar = new (vehiculo.IdVehiculo, fechaSolicitada);
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
            float precio=0;
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
                    retorno= true;
                    break;
                }
                
            }
            return retorno;
        }
        public static int CalcularIdViaje()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje)+1;
            return retorno;
        }
        public static Usuario ValidarUsuario(Usuario usuarioUno)
        {
            Usuario? retorno = null;

            foreach (Empleado empleado in listaEmpleado)
            {
                if (empleado == usuarioUno && empleado.Estado==1)
                {
                    retorno = empleado;
                    break;
                }
            }
            if (retorno == null)
            {
                foreach (Cliente cliente in listaClientes)
                {
                    if (cliente == usuarioUno && cliente.Estado == 1)
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
            foreach (Cliente empleado in listaClientes)
            {
                if (empleadoUno == empleado)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static Cliente BuscarCliente(Usuario usuarioUno)
        {
            Cliente? retorno = null;
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente == usuarioUno)
                {
                    retorno = cliente;
                    break;
                }
            }
            return retorno;
        }
    }
}
