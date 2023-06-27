using Google.Cloud.Firestore;

namespace TransporteRodriguez
{
    [FirestoreData]
    public class Usuario
    {
        //? por los retornos nulos
        private string _nombre;
        private string _contraseña;
        private string _mail;
        private bool _estado;


        public Usuario() { }

        
        public Usuario(string nombre, string contraseña, string mail, bool estado)
        {
            _nombre = nombre;
            _contraseña = contraseña;
            _mail = mail;
            _estado = estado;
        }
        
        public Usuario(string nombre, string contraseña)
        {
            _nombre = nombre;
            _contraseña = contraseña;
        }

        //public Usuario(string nombre, string contraseña) : this(nombre, contraseña, "SIN MAIL"){ }
        //INTENTO SOBRECARGAR 

        [FirestoreProperty]
        public string Nombre { get => _nombre; set => _nombre = value;}
        [FirestoreProperty]
        public string Contraseña { get => _contraseña; set => _contraseña = value;}
        [FirestoreProperty]
        public string Mail { get => _mail; set => _mail = value;}
        [FirestoreProperty]
        public bool Estado { get => _estado; set => _estado = value; }

        public virtual bool ValidarUsuario(Usuario user)
        {
            return true;
        }

        public virtual int generarId()
        {
            return 0;
        }
    }
}