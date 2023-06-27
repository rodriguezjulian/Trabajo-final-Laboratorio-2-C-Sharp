using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_FireBase
{
    [FirestoreData]
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        [FirestoreProperty]
        public string Nombre { get => nombre; set => nombre = value; }
        [FirestoreProperty]
        public string Apellido { get => apellido; set => apellido = value; }
        public Empleado()
        {

        }

        public Empleado(string nombre,string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

        }



    }
}
