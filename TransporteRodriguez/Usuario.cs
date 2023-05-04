namespace TransporteRodriguez
{
    public class Usuario
    {
        //? por los retornos nulos
        private string? nombre;
        private string? contraseña;
        private string? mail;

        public Usuario() { }
        //public Usuario(string nombre, string contraseña) : this(nombre, contraseña, "SIN MAIL"){ }
        //INTENTO SOBRECARGAR 
        public Usuario(string nombre, string contraseña, string mail)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }

        //EVALUAR SI PRECISO TODOS LOS SETS
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Contraseña { get => contraseña; set => contraseña = value; }
        public string? Mail { get => mail; set => mail = value; }
    }
}