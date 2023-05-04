using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal class Viaje
        // nose si podria hacer que viaje herede de cliente los datos de nombre cliente y direccion de salida
    {
        private short idViaje;
        private string? nombreCliente;
        private string? direccionSalida; // que seria la direccion del cliente
        private string? provinciaDestino;
        private float precio;
        private short idVehiculo;
        private DateTime fechaViaje;
    }
}
