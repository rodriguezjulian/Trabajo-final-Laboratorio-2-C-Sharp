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

        public static List<Empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }
        public override void Agregar()
        {
            if (ListaEmpleado.Count == 0)
            {
                ListaEmpleado.Add(new Empleado("Usuario", "Contraseña", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
                ListaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
                ListaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", true, 2, "Analista de Sistemas"));
                ListaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", true, 3, "Asistente Administrativo"));
                ListaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", true, 4, "Desarrollador Web"));
                ListaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", true, 5, "Contador General"));
            }
        }
       /* public static void AgregarEmpleado()
        {
            ListaEmpleado.Add(new Empleado("Usuario", "Contraseña", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
            ListaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", true, 1, "Gerente de Ventas"));
            ListaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", true, 2, "Analista de Sistemas"));
            ListaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", true, 3, "Asistente Administrativo"));
            ListaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", true, 4, "Desarrollador Web"));
            ListaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", true, 5, "Contador General"));

        }*/
        public static Empleado BuscarEmpleado(Usuario usuarioUno)
        {
            Empleado retorno = null;
            foreach (Empleado empleado in ListaEmpleado)
            {
                if (empleado == usuarioUno)
                {
                    retorno = empleado;
                    break;
                }
            }
            return retorno;
        }
    }
}