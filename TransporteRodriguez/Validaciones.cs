using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Validaciones
    {
        public static bool VerificarIdIngresado(string ID, out int IDINT)
        {
            bool retorno = false;
            int idEntero;
            if (ID == "")
            {
                throw new Exception("ERROR, Ingrese un ID o elija una fila haciendole click");
            }
            else
            {
                if (int.TryParse(ID, out idEntero) == false)
                {
                    throw new Exception("ERROR, Ingrese un numero como ID");
                }
                else
                {
                    IDINT = idEntero;
                    retorno = true;
                }
            }
            return retorno;
        }
        //NO SE PODRAN DAR DE BAJA NI MODIFICAR VIAJES QUE YA HAN EXISTIDO
        public static bool VerificarFecha(DateTime fechaVieja)
        {
            bool retorno;
            if (fechaVieja < DateTime.Today)
            {
                throw new Exception("ERROR, No puede modificar o dar de baja un viaje que ya se realizo.");
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool VerificarkgIngresado(string kgS, out float kg)
        {
            float kgFloat;
            bool retorno;
            if (kgS == "")
            {
                throw new Exception("ERROR, Ingrese una cantidad de KG a transportar");
            }
            else
            {
                if (float.TryParse(kgS, out kgFloat) == false)
                {
                    throw new Exception("ERROR, Ingrese un numero para KG");
                }
                else
                {
                    if (kgFloat < 50 || kgFloat > 2000)
                    {
                        throw new Exception("ERROR, Peso minimo a transportar: 50\nPeso maximo a transportar: 2000.");
                    }
                    else
                    {
                        kg = kgFloat;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
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
                    if (!char.IsLetter(caracter) && caracter != 32)
                    {
                        retorno = false;
                        throw new Exception("ERROR, Ingrese un nombre valido (sin números ni simbolos).");
                    }
                }
            }
            else
            {
                throw new Exception("ERROR, Ingrese un nombre.");
            }
            return retorno;
        }
        public static bool VerificarMail(string despuesDelArroba)
        {
            bool retorno = false;
            foreach (char caracter in despuesDelArroba)
            {
                if (caracter == 64)
                {
                    retorno = true;
                }
            }
            if (retorno == false)
            {
                throw new Exception("ERROR, Recuerde incluir el @mail \n Por ejemplo @gmail.com");
            }
            return retorno;
        }
        public static bool VerificarCuerpoMail(string mail)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(mail))
            {
                retorno = false;
                throw new Exception("ERROR, Ingrese cuerpo del mail.");
            }
            else
            {
                foreach (char caracter in mail)
                {
                    if (caracter == '@')
                    {
                        retorno = false;
                        throw new Exception("No debes incluir @ en el cuerpo de tu mail.\n El mismo se agrega automaticamente.");
                    }
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
            List<Empleado> ListaEmpleados = Conexion_SQL.ObtenerEmpleados("empleados");
            foreach (Empleado empleado in ListaEmpleados)
            {
                if (empleado == usuarioUno && empleado.Estado == true)
                {
                    retorno = empleado;
                    break;
                }
            }
            if (retorno == null)
            {
                List<Cliente> lista = Conexion_SQL.ObtenerClientes("clientes");
                foreach (Cliente cliente in lista)
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
            List<Vehiculo> listaVehiculosAux = Conexion_SQL.ObtenerVehiculos("vehiculos");
            foreach (Vehiculo vehiculo in listaVehiculosAux)
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
        public static bool VerificarPatente(string patenteIngresada)
        {
            bool retorno = true;
            string patenteAuxiliar = patenteIngresada.ToUpper();
            if (VerificarFormatoPatente(patenteAuxiliar) != true)
            {
                retorno = false;
                throw new Exception("ERROR, Verifique la patente ingresada\n");
            }
            else
            {
                if (VerificarExistenciaPatente(patenteAuxiliar) != true)
                {
                    retorno = false;
                    throw new Exception("ERROR, La patente ingresada pertenece a un vehiculo existente\n");
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
        public static bool VerificarViajesPendientes(Vehiculo vehiculo)
        {
            bool retorno = true;
            List<Viaje> listaViajes = Conexion_SQL.ObtenerViajes("viajes");
            foreach (Viaje viaje in listaViajes)
            {
                if (viaje.IdVehiculo == vehiculo.IdVehiculo && viaje.Estado == true && viaje.FechaViaje > DateTime.Today)
                {
                    retorno = false;
                    throw new Exception("ERROR, No puede eliminar un vehiculo que tenga viajes pendiente.");
                }
            }
            return retorno;
        }
    }
}
