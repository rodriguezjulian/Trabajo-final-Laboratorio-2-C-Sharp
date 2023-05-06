using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Viaje
        // nose si podria hacer que viaje herede de cliente los datos de nombre cliente y direccion de salida
    {
        private short _idViaje;
        private string? _nombreCliente;
        private string? _direccionSalida; // que seria la direccion del cliente
        private string? _provinciaDestino;
        private float _precio;
        private short _idVehiculo;
        private DateTime _fechaViaje;

        public Viaje(short idViaje, string? nombreCliente, string? direccionSalida, string? provinciaDestino, float precio, short idVehiculo, DateTime fechaViaje)
        {
            IdViaje = idViaje;
            NombreCliente = nombreCliente;
            DireccionSalida = direccionSalida;
            ProvinciaDestino = provinciaDestino;
            Precio = precio;
            IdVehiculo = idVehiculo;
            FechaViaje = fechaViaje;
        }

        public short IdViaje { get => _idViaje; set => _idViaje = value; }
        public string? NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string? DireccionSalida { get => _direccionSalida; set => _direccionSalida = value; }
        public string? ProvinciaDestino { get => _provinciaDestino; set => _provinciaDestino = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public short IdVehiculo { get => _idVehiculo; set => _idVehiculo = value; }
        public DateTime FechaViaje { get => _fechaViaje; set => _fechaViaje = value; }
    }
}
