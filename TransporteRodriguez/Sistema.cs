using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Sistema
    {
        static List<Cliente> listaClientes = new List<Cliente>();
        static List<Empleado> listaEmpleado = new List<Empleado>();
        
       /*public static int AgregarUsuario(string opcionCboLogin)
        {
            int retorno;
            if (opcionCboLogin == "Cliente")
            {
                AgregarCliente();
                retorno = 0;
            }
            else
            {
                if (opcionCboLogin == "Empleado")
                {
                    AgregarEmpleado();
                    retorno = 1;
                }
                else
                {
                    AgregarAdmin();
                    retorno = 2;
                }
            }
            return retorno;
        }*/
        public static void AgregarCliente()
        {           
            listaClientes.Add(new Cliente("Juan Pérez", "juan123", "juan.perez@gmail.com", 1, "Av. Belgrano 1234", "Libros"));       
            listaClientes.Add(new Cliente("María García", "maria456", "maria.garcia@hotmail.com", 2, "Calle 25 de Mayo 5678", "Electrodomésticos"));       
            listaClientes.Add(new Cliente("Lucas Martínez", "lucas789", "lucas.martinez@yahoo.com", 3, "Av. Corrientes 2468", "Muebles"));        
            listaClientes.Add(new Cliente("Ana Rodríguez", "ana000", "ana.rodriguez@gmail.com", 4, "Calle Florida 4321", "Ropa"));        
            listaClientes.Add(new Cliente("Pedro González", "pedro111", "pedro.gonzalez@hotmail.com", 5, "Calle Reconquista 6789", "Juguetes"));         
            listaClientes.Add(new Cliente("Laura Fernández", "laura222", "laura.fernandez@yahoo.com", 6, "Av. Santa Fe 2468", "Calzado"));      
            listaClientes.Add(new Cliente("Javier Díaz", "javier333", "javier.diaz@gmail.com", 7, "Calle Maipú 3456", "Hogar"));        
            listaClientes.Add(new Cliente("Carla Castro", "carla444", "carla.castro@hotmail.com", 8, "Calle Lavalle 6789", "Mascotas"));           
            listaClientes.Add(new Cliente("Martín Suárez", "martin555", "martin.suarez@yahoo.com", 9, "Av. San Martín 1234", "Jardín"));    
            listaClientes.Add(new Cliente("Silvia López", "silvia666", "silvia.lopez@gmail.com", 10, "Calle Esmeralda 5678", "Salud"));         
            listaClientes.Add(new Cliente("Federico Torres", "federico777", "federico.torres@hotmail.com", 11, "Av. Pueyrredón 2468", "Belleza"));        
            listaClientes.Add(new Cliente("Valeria Gómez", "valeria888", "valeria.gomez@yahoo.com", 12, "Calle Callao 4321", "Computación"));     
            listaClientes.Add(new Cliente("Pablo Ramírez", "pablo999", "pablo.ramirez@gmail.com", 13, "Av. Córdoba 6789", "Herramientas"));
            listaClientes.Add(new Cliente("Romina Acosta", "romina123", "romina.acosta@hotmail.com", 14, "Calle Mendoza 3456", "Deportes"));
        }
        public static void AgregarEmpleado()
        {
            listaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", 1, "Gerente de Ventas"));
            listaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", 2, "Analista de Sistemas"));
            listaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", 3, "Asistente Administrativo"));
            listaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", 4, "Desarrollador Web"));
            listaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", 5, "Contador General"));
        }
        private static void AgregarAdmin() 
        {
            
        }

        /*public static bool ValidarUsuario(Usuario nombre)
        {
            bool retorno = false;
            foreach (Usuario empleado in listaEmpleado)
            {
                if (nombre == empleado)
                {
                    retorno = true;
                }
            }
            foreach (Cliente cliente in listaClientes)
            {
                if (nombre == cliente)
                {
                    retorno = true;
                }
            }

            return retorno;
        }*/


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
        /*public static bool ValidarUsuario(Empleado empleadoUno)
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
        }*/


    }
}
