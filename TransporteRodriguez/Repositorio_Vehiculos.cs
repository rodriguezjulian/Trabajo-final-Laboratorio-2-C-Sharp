using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Vehiculos
    {
        private static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public static List<Vehiculo> ListaVehiculos { get => listaVehiculos; set => listaVehiculos = value; }

        public static void AgregarVehiculos()
        {
            listaVehiculos.Add(new Vehiculo(1, Marcas.Fiat, 1000, Colores.Rojo, "ABC123"));
            listaVehiculos.Add(new Vehiculo(2, Marcas.Scania, 1500, Colores.Gris, "DEF456"));
            listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "GHI789"));
            listaVehiculos.Add(new Vehiculo(4, Marcas.Volkswagen, 500, Colores.Azul, "JKL012"));
            listaVehiculos.Add(new Vehiculo(5, Marcas.Iveco, 1200, Colores.Blanco, "MNO345"));
        }
        public static int RetornarVehiculoDisponible(float kilos, DateTime fechaSolicitada)
        {
            float cargaSoportada;
            Viaje viajeAxuliar;
            //vehiculos aptos para transportar la cantidad de kilos.
            int retorno = 0;
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                cargaSoportada = vehiculo.CapacidadDeCarga;
                //busco 1 vehiculo que soporte el peso
                if (cargaSoportada >= kilos)
                {
                    //CREO UN VIAJE CON ESE VEHICULO EN ESA FECHA
                    viajeAxuliar = new(vehiculo.IdVehiculo, fechaSolicitada);
                    //SI YA HAY UN VIAJE CON ESA FECHA Y ESE IDVEHICULO, NO SE ROMPE EL BUCLE
                    //EN CASO QUE NO SEA POSIBLE ENCONTRAR UN VEHICULO DISPONIBLE RETORNO=0;
                    if (Repositorio_Viajes.VerificarDisponibilidadFecha(viajeAxuliar))
                    {
                        retorno = vehiculo.IdVehiculo;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static bool VerificarPatente(string patenteIngresada)
        {
            bool retorno = true;
            // Verificar longitud del string
            if (patenteIngresada.Length != 6)
            {
                retorno= false;
            }

            // Verificar caracteres individualmente
            for (int i = 0; i < patenteIngresada.Length; i++)
            {
                if (i < 3 && !char.IsDigit(patenteIngresada[i])) // Los primeros tres caracteres deben ser dígitos
                {
                    retorno =false;
                }
                if (i >= 3 && !char.IsLetter(patenteIngresada[i])) // Los últimos tres caracteres deben ser letras
                {
                    retorno= false;
                }
            }

            return retorno;
        }
        public static int CalcularIdVehiculo()
        {
            int retorno;
            Vehiculo clienteUltimo = ListaVehiculos[ListaVehiculos.Count - 1];
            retorno = (clienteUltimo.IdVehiculo) + 1;
            return retorno;
        }
    }
}
