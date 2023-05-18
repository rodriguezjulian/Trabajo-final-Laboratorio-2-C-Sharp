using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Validaciones
    {
        public static bool VerificarNombre(string nombre)
        {
            bool retorno = true;
            if (!string.IsNullOrEmpty(nombre))
            {
                foreach (char caracter in nombre)
                {
                    if (char.IsDigit(caracter))
                    {
                        retorno = false;
                    }
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool VerificarMail(string mail)
        {
            bool retorno = true;
            foreach (char caracter in mail)
            {
                if (caracter == '@')
                {
                    return false;
                }
            }
            return retorno;
        }
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
    }
}
