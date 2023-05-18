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
        private int _idViaje;
        private string _nombreCliente;
        private string _direccionSalida; // que seria la direccion del cliente
        private string _provinciaDestino;
        private float _kilosATransportar;
        private float _precio;
        private int _idVehiculo;
        private DateTime _fechaViaje;

        public Viaje(int idViaje, string nombreCliente, 
            string direccionSalida, string provinciaDestino, float kilosATransportar, float precio, int idVehiculo, DateTime fechaViaje)
        {
            _idViaje = idViaje;
            _nombreCliente = nombreCliente;
            _direccionSalida = direccionSalida;
            _provinciaDestino = provinciaDestino;
            _kilosATransportar = kilosATransportar;
            _precio = precio;
            _idVehiculo = idVehiculo;
            _fechaViaje = fechaViaje;
        }
        public Viaje(int idVehiculo, DateTime fechaViaje)
        {
            _idVehiculo = idVehiculo;
            _fechaViaje = fechaViaje;
        }
        public int IdViaje { get => _idViaje; set => _idViaje = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string DireccionSalida { get => _direccionSalida; set => _direccionSalida = value; }
        public string ProvinciaDestino { get => _provinciaDestino; set => _provinciaDestino = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public int IdVehiculo { get => _idVehiculo; set => _idVehiculo = value; }
        public DateTime FechaViaje { get => _fechaViaje; set => _fechaViaje = value; }
        public float KilosATransportar { get => _kilosATransportar; set => _kilosATransportar = value; }

        public static bool operator ==(Viaje uno, Viaje dos)
        {
            bool retorno = false;
            if (uno.IdVehiculo == dos.IdVehiculo && uno.FechaViaje.Date == dos.FechaViaje.Date)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Viaje uno, Viaje dos)
        {
            return !(uno == dos);
        }
       public override string ToString()
        {
            StringBuilder miCadena = new StringBuilder();
           // miCadena.AppendLine("VIAJE CONFIRMADO");
            miCadena.AppendLine("ID VIAJE: " + IdViaje);
            miCadena.AppendLine("Direccion de Salida: " + DireccionSalida);
            miCadena.AppendLine("Provincia destino: " + ProvinciaDestino);
            miCadena.AppendLine("Precio: " + Precio);
            miCadena.AppendLine("Kilos a transportar: " + KilosATransportar);
            miCadena.AppendLine("Fecha: " + FechaViaje);
            return miCadena.ToString();
        }
    }
}
