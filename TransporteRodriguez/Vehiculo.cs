using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerado;

namespace TransporteRodriguez
{
    internal class Vehiculo
    {
        private short _idVehiculo;
        private Marcas _marcaVehiculo;
        private int _capacidadDeCarga;
        private Colores _color;
        private string? _patente;

        public Vehiculo() { }

        public Vehiculo(short idVehiculo, Marcas marcaVehiculo, int capacidadDeCarga, Colores color, string? patente)
        {
            _idVehiculo = idVehiculo;
            _marcaVehiculo = marcaVehiculo;
            _capacidadDeCarga = capacidadDeCarga;
            _color = color;
            _patente = patente;
        }

        public short IdVehiculo { get => _idVehiculo; set => _idVehiculo = value; }
        public Marcas MarcaVehiculo { get => _marcaVehiculo; set => _marcaVehiculo = value; }
        public int CapacidadDeCarga { get => _capacidadDeCarga; set => _capacidadDeCarga = value; }
        public Colores Color { get => _color; set => _color = value; }
        public string? Patente { get => _patente; set => _patente = value; }
    }
}
