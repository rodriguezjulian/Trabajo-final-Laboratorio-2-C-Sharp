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
         {
                Repositorio_Viajes.AgregarViajes();
                Repositorio_Vehiculos.AgregarVehiculos();
                Repositorio_Clientes.AgregarCliente();
                Repositorio_Empleados.AgregarEmpleado();
         }

        public static Usuario ValidarUsuario(Usuario usuarioUno)
        {
            Usuario? retorno = null;

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
    }
}

