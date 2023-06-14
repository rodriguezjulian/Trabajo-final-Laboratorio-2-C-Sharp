using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Validaciones
    {
        /// <summary>
        /// Verificamos que string no se incluya un numero ni este vacio ("") o null
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
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
                        throw new Exception("ERROR, Ingrese un nombre valido (sin números).");
                    }
                }
            }
            else
            {
                throw new Exception("ERROR, Ingrese un nombre.");
            }
            return retorno;
        }
        /// <summary>
        /// Verificamos que en el cuerpo del mail antes del @ no se incluya un @
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool VerificarMail(string mail)
        {
            bool retorno = true;
            foreach (char caracter in mail)
            {
                if (caracter == '@')
                {

                    retorno= false;

                    throw new Exception("No debes incluir @ en el cuerpo de tu mail.\n El mismo se agrega automaticamente.");
                }
            }
            return retorno;
        }
        /// <summary>
        /// Validamos que el usuario logueado este incluido en la lista de clientes o empleados estando activos
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Verificamos que la patente ingresada al crear un vehiculo no este cargada en sistema asociada a otro vehiculo.
        /// No pueden existir 2 vehiculos con la misma patente.
        /// </summary>
        /// <param name="patenteIngresada"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Apoyandonos en VerificarPatente y en VerificarExistenciaPatente, validamos el ingreso de la misma con una sola llamada.
        /// retona 0 todo bien || 1 esta mal el formato || 2 ya existe la patente
        /// </summary>
        /// <param name="patenteIngresada"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Verificaremos el correcto formato de la patente ingresada 
        /// </summary>
        /// <param name="patenteIngresada"></param>
        /// <returns></returns>
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
