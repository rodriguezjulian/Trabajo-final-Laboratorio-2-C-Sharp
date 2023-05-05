using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal class Empleado : Usuario
    {
        private short _idEmpleado;
        private string? _puesto;
        public Empleado() { }

        public Empleado(string nombre, string contraseña, string mail,short idEmpleado, string puesto) : base(nombre, contraseña, mail)
        {
            this.IdEmpleado = idEmpleado;
            this.Puesto = puesto;
        }

        public short IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string? Puesto { get => _puesto; set => _puesto = value; }
    }
}
