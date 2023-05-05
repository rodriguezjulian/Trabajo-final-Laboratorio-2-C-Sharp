using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Cliente : Usuario
    {
        private short _idCliente; // Ver la manera de que sea autoincremental
        private string? _direccionBSAS;
        private string? _rubro; // podria sacarlo de un enumerado - sobrecargar constructor para que no sea obligatorio

        public Cliente() { }

        public Cliente(string nombre, string contraseña, string mail,short idCliente, string? direccionBSAS, string? rubro) 
            : base(nombre, contraseña, mail)
        {
            _idCliente = idCliente;
            _direccionBSAS = direccionBSAS;
            _rubro = rubro;
        }
        public static bool operator ==(Cliente uno, Cliente dos)
        {
            bool retorno = false;
            if ((uno.Nombre == dos.Nombre) && (uno.Contraseña == dos.Contraseña))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cliente uno, Cliente dos)
        {
            return !(uno == dos);
        }
        // listaClientes.Add(new Cliente("pedro", "ashe", pedro@yahoo.com,1,Libertador 45,Textil));
    }
}
