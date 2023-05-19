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
        public static bool VerificarExistenciaPatente(string patenteIngresada)
        {
            bool retorno = true;
            foreach (Vehiculo vehiculo in Repositorio_Vehiculos.ListaVehiculos)
            {
                if (vehiculo.Patente == patenteIngresada)
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        // retona 0 todo bien || 1 esta mal el formato || 2 ya existe la patente
        public static int VerificarPatente(string patenteIngresada)
        {
            int retorno = 0;
            string patenteAuxiliar = patenteIngresada.ToUpper();
            if (VerificarFormatoPatente(patenteAuxiliar) != true)
            {
                retorno = 1;
            }
            else
            {
                if (VerificarExistenciaPatente(patenteAuxiliar) != true)
                {
                    retorno = 2;
                }
            }
            return retorno;
        }
        public static bool VerificarFormatoPatente(string patenteIngresada)
        {
            bool retorno = true;
            // Verificar longitud del string
            if (patenteIngresada.Length != 6)
            {
                retorno = false;
            }

            // Verificar caracteres individualmente
            for (int i = 0; i < patenteIngresada.Length; i++)
            {
                if (i < 3 && !char.IsDigit(patenteIngresada[i])) // Los primeros tres caracteres deben ser dígitos
                {
                    retorno = false;
                }
                if (i >= 3 && !char.IsLetter(patenteIngresada[i])) // Los últimos tres caracteres deben ser letras
                {
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
