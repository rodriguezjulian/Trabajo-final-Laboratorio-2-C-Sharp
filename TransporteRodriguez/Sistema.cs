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
        static Sistema()
        { }
        /// <summary>
        /// Se crea un mail a partir del parametro mail que contendra la direccion sin @ y el tipo de mail elegido desde un combo box
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="opcionCbo"></param>
        /// <param name="mailFinal"></param> se devuelve el mail definitivo que  luego formara parte de distintos tipos de objeto
        /// <returns></returns>
        public static bool CrearMail(string mail, string opcionCbo, out string mailFinal)
        {
            bool retorno = false;
            mailFinal = "";
            if (mail != "")
            {
                if (Validaciones.VerificarMail(mail))
                {
                    mailFinal = mail + opcionCbo;
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// A la hora de modificar el mail, debemos obtener el tipo descomponiendo al mail completo y obteniendo solo lo que esta a partir del @
        /// </summary>
        /// <param name="mailCompleto"></param>
        /// <returns></returns>
        public static string ObtenerTipoMail(string mailCompleto)
        {
            string tipoMail = "";
            int arrobaIndex = mailCompleto.IndexOf("@");

            if (arrobaIndex != -1 && arrobaIndex < mailCompleto.Length - 1)
            {
                tipoMail = "@" + mailCompleto.Substring(arrobaIndex + 1);
            }
            return tipoMail;
        }
        /// <summary>
        /// A la hora de modificar el mail, debemos obtener el cuerpo del mail que se encuentre antes del @
        /// </summary>
        /// <param name="mailCompleto"></param>
        /// <returns></returns>
        public static string ObtenerUsuarioMail(string mailCompleto)
        {
            string usuarioMail = "";
            int arrobaIndex = mailCompleto.IndexOf("@");

            if (arrobaIndex != -1)
            {
                usuarioMail =mailCompleto.Substring(0, arrobaIndex);
            }

            return usuarioMail;
        }
        /// <summary>
        /// Generaremos una contraseña random por seguridad
        /// </summary>
        /// <returns></returns>
        public static string generarContraseña()
        {
            Random random = new Random();
            string numeros = "";
            for (int i = 0; i < 5; i++)
            {
                numeros += random.Next(0, 100).ToString() + " ";
            }
            return numeros;
        }
        /// <summary>
        /// poblamos todas las listas apoyandonos en el metodo Agregar() incluido en cada repositorio especifico
        /// </summary>
        public static void PoblarListas()
        {
            Repositorio_Empleados.Repo_Empleados.Agregar();  
            Repositorio_Clientes.Repo_Clientes.Agregar();
            Repositorio_Vehiculos.Repo_Vehiculos.Agregar();
            Repositorio_Viajes.Repo_Viajes.Agregar();
        }

    }
}

