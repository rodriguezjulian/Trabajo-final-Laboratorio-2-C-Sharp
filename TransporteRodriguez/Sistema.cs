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

        private static List<Empleado> listaEmpleado = new List<Empleado>();

        static Sistema()
        { }
        

        public static Usuario ValidarUsuario(Usuario usuarioUno)
        {
            Usuario retorno = null;

            foreach (Empleado empleado in Repositorio_Empleados.ListaEmpleado)
            {
                if (empleado == usuarioUno && empleado.Estado == true)
                {
                    retorno = empleado;
                    break;
                }
            }
            if (retorno == null)
            {
                foreach (Cliente cliente in Repositorio_Clientes.ListaClientes)
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
        public static void PoblarListas(){

            Repositorio_Empleados repositorio_empleados = new Repositorio_Empleados();
            repositorio_empleados.Agregar();
            Repositorio_Clientes repositorio_Clientes = new Repositorio_Clientes();
            repositorio_Clientes.Agregar();
            Repositorio_Vehiculos repositorio_Vehiculos = new Repositorio_Vehiculos();
            repositorio_Vehiculos.Agregar();
            Repositorio_Viajes repositorio_Viajes = new Repositorio_Viajes();
            repositorio_Viajes.Agregar();
        }

    }
}

