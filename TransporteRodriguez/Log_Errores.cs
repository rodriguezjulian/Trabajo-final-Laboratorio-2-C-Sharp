using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public static class Log_Errores
    {
        public static void EscribirLogErrores(Exception ex)
        {
            string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string descripcion = ex.Message;
            string clase = ex.TargetSite.DeclaringType.FullName;
            string metodo = ex.TargetSite.Name;

            string registro = $"Fecha y hora: {fechaHora}\nDescripción: {descripcion}\nClase: {clase}\nMétodo: {metodo}\n\n";

            // string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ar\LogErrores.txt"; // Especifica la ruta donde deseas guardar el archivo
            string rutaArchivo = @"C:\Users\Julian Rodriguez\Desktop\LaboratorioDos\ppLaboratorio2B---SEGUNDO-INTENTO\LogErrores.txt";

            // Escribir el registro en el archivo de texto
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(registro);
            }
        }
        public static void DispararLog(object sender, EventArgs e)
        {
            //EscribirLogErrores

        }

    }
}
