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
        private short idVehiculo;
        private Marcas marcaVehiculo;
        private int capacidadDeCarga;
        private Colores color;
        private string? patente;

        public Vehiculo() { }

        public Vehiculo(short idVehiculo, Marcas marcaVehiculo, int capacidadDeCarga, Colores color, string? patente)
        {
            this.IdVehiculo = idVehiculo;
            this.MarcaVehiculo = marcaVehiculo;
            this.CapacidadDeCarga = capacidadDeCarga;
            this.Color = color;
            this.Patente = patente;
        }

        public short IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public Marcas MarcaVehiculo { get => marcaVehiculo; set => marcaVehiculo = value; }
        public int CapacidadDeCarga { get => capacidadDeCarga; set => capacidadDeCarga = value; }
        public Colores Color { get => color; set => color = value; }
        public string? Patente { get => patente; set => patente = value; }
    }
}
