namespace TransporteRodriguez
{
    public class Usuario
    {
        //? por los retornos nulos
        private string? _nombre;
        private string? _contraseña;
        private string? _mail;

        public Usuario() { }

        public Usuario(string? nombre, string? contraseña, string? mail)
        {
            _nombre = nombre;
            _contraseña = contraseña;
            _mail = mail;
        }

        //public Usuario(string nombre, string contraseña) : this(nombre, contraseña, "SIN MAIL"){ }
        //INTENTO SOBRECARGAR 


        public string? Nombre { get => _nombre; set => _nombre = value; }
        public string? Contraseña { get => _contraseña; set => _contraseña = value; }
        public string? Mail { get => _mail; set => _mail = value; }
        public virtual bool ValidarUsuario(Usuario user)
        {
            return true;
        }
        //EVALUAR SI PRECISO TODOS LOS SETS

    }
}