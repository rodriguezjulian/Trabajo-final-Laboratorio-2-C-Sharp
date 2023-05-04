using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal class Cliente : Usuario
    {
        private short idCliente; // Ver la manera de que sea autoincremental
        private string? direccionBSAS;
        private string? rubro; // podria sacarlo de un enumerado - sobrecargar constructor para que no sea obligatorio

        public Cliente() { }

        public Cliente(string nombre, string contraseña,string mail,short idCliente, string? direccionBSAS, string? rubro) 
        : base (nombre, contraseña, mail)
        {
            this.idCliente = idCliente;
            this.direccionBSAS = direccionBSAS;
            this.rubro = rubro;
        }
    }
}
