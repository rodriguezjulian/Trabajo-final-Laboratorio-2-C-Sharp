namespace TransporteRodriguez
{
    public class Usuario
    {
        //? por los retornos nulos
        private string? _nombre;
        private string? _contraseña;
        private string? _mail;

        public Usuario() { }
        //public Usuario(string nombre, string contraseña) : this(nombre, contraseña, "SIN MAIL"){ }
        //INTENTO SOBRECARGAR 
        public Usuario(string nombre, string contraseña, string mail)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }

        public string? Nombre { get => _nombre; set => _nombre = value; }
        public string? Contraseña { get => _contraseña; set => _contraseña = value; }
        public string? Mail { get => _mail; set => _mail = value; }

        //EVALUAR SI PRECISO TODOS LOS SETS

    }
}