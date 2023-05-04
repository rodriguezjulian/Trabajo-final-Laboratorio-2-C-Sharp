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
        private short _idViaje;
        private string? _nombreCliente;
        private string? _direccionSalida; // que seria la direccion del cliente
        private string? _provinciaDestino;
        private float _precio;
        private short _idVehiculo;
        private DateTime _fechaViaje;
    }
}
