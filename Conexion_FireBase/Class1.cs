using Google.Cloud.Firestore;
namespace Conexion_FireBase
{
    public class FireConnections
    {
      /* public static async Task<bool> Agregar (Empleado empleadoAux,string id)
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
       /* return true;
       }
       */
    /*public static async Task<List<AlumnoFire>> Leer()
    {
        var listaAlumnos = new List<AlumnoFire>();

        var projectId = "prog-2-e0bdd";

        FirestoreDb db = FirestoreDb.Create(projectId);

        var colRef = db.Collection("alumnos2");

        var query = colRef.Limit(20);

        var snapsShot = await query.GetSnapshotAsync();

        var lista = snapsShot.ToList();

        foreach (var item in lista)
        {
            var alumno = item.ConvertTo<AlumnoFire>();

            listaAlumnos.Add(alumno);
        }

        return listaAlumnos;
    }

    public static FirestoreChangeListener TraerRealTime()
    {
        var listaAlumnos = new List<AlumnoFire>();

        var projectId = "prog-2-e0bdd";

        FirestoreDb db = FirestoreDb.Create(projectId);

        var colRef = db.Collection("alumnos2");

        var query = colRef.Limit(20);

        FirestoreChangeListener listener = query.Listen(snapshot => {

            foreach (var item in snapshot)
            {
                AlumnoFire alumno = item.ConvertTo<AlumnoFire>();
                alumno.Id = item.Id;

                Console.WriteLine(alumno.Nombre + " " + alumno.Apellido);
            }

        });

        return listener;
    }*/
}
}