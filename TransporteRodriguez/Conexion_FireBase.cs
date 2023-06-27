using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Conexion_FireBase
    {
        public static async Task<bool> Agregar(Empleado empleadoAux, string id)
        {
            //pruebauno-b13dc
            var projectId = "pruebauno-b13dc";

            FirestoreDb db = FirestoreDb.Create(projectId);
            //TE DEVUELVE LA REFERENCIA DE LA COLLECION
            var colRef = db.Collection("empleados");
            DocumentReference documentRef = colRef.Document(id);

            //await => HILOS
            var rta = await documentRef.SetAsync(empleadoAux);


            /*Thread hilo = Thread.CurrentThread;
            int hiloId = hilo.ManagedThreadId;*/
            return true;
        }
    }
}
