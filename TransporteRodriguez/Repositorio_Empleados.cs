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
        
        public override int CalcularId()
        {
            int retorno;
            Empleado ultimo = ListaEmpleado[ListaEmpleado.Count - 1];
            retorno = (ultimo.IdEmpleado) + 1;
            return retorno;
        }
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
        public override Empleado DarDeBaja(int ID)
        {
            Empleado empleado = BuscarInstanciaId(ID);
            if (empleado.Estado == true)
            {
                empleado.Estado = false;
            }
            return empleado;
        }
    }
}