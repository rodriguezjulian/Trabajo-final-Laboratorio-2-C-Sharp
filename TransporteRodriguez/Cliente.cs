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
    }
}
