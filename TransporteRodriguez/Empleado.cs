using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal class Empleado : Usuario
    {
        private short idEmpleado;
        private string? puesto;
        public Empleado() { }

        public Empleado(short idEmpleado, string puesto)
        {
            this.IdEmpleado = idEmpleado;
            this.Puesto = puesto;
        }
        public short IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string? Puesto { get => puesto; set => puesto = value; }
    }
}
