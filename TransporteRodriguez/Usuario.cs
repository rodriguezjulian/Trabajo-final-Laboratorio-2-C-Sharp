namespace TransporteRodriguez
{
    public class Usuario
    {
        //? por los retornos nulos
        private string? nombre;
        private string? contraseña;
        private string? mail;
        // no activo=0 || activo=1
        private int estado;

        public Usuario() { }

        public Usuario(string? nombreUsuario, string? contraseñaUsuario, string? mailUsuario, int activoUsuario)
        {
            nombreUsuario = nombre;
            contraseñaUsuario = contraseña;
            mailUsuario = mail;
            activoUsuario = Estado;

        }

        public Usuario(string? nombreUsuario, string? contraseñaUsuario)
        {
            nombreUsuario = nombre;
            contraseñaUsuario = contraseña;
        }

        public string? Nombre { get => nombre; set => nombre = value;}
        public string? Contraseña { get => contraseña; set => contraseña = value;}
        public string? Mail { get => mail; set => mail = value;}
        public int Estado { get => estado; set => estado = value; }

        public virtual bool ValidarUsuario(Usuario user)
        {
            return true;
        }
        //EVALUAR SI PRECISO TODOS LOS SETS

    }
}