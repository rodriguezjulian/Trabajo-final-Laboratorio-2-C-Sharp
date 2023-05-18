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
        public static string ObtenerTipoMail(string mailCompleto)
        {
            string tipoMail = "";
            int arrobaIndex = mailCompleto.IndexOf("@");

            if (arrobaIndex != -1 && arrobaIndex < mailCompleto.Length - 1)
            {
                tipoMail = mailCompleto.Substring(arrobaIndex + 1);
            }
            return tipoMail;
        }
        public static string ObtenerUsuarioMail(string mailCompleto)
        {
            string usuarioMail = "";
            int arrobaIndex = mailCompleto.IndexOf("@");

            if (arrobaIndex != -1)
            {
                usuarioMail = mailCompleto.Substring(0, arrobaIndex);
            }

            return usuarioMail;
        }

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
        public static void PoblarListas()
        {
            Repositorio_Empleados repositorio_empleados = new Repositorio_Empleados();
            Repositorio_Viajes repositorio_Viajes = new Repositorio_Viajes();
            Repositorio_Clientes repositorio_Clientes = new Repositorio_Clientes();
            Repositorio_Vehiculos repositorio_Vehiculos = new Repositorio_Vehiculos();
            repositorio_empleados.Agregar();
            repositorio_Clientes.Agregar();
            repositorio_Vehiculos.Agregar();  
            repositorio_Viajes.Agregar();
        }

    }
}

