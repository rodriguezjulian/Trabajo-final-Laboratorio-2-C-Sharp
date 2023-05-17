using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Vehiculos : Repositorio_Padre
    {
        private static List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public static List<Vehiculo> ListaVehiculos { get => listaVehiculos; set => listaVehiculos = value; }

        public override void Agregar()
        {
            if(ListaVehiculos.Count==0) 
            {
                listaVehiculos.Add(new Vehiculo(1, Marcas.Fiat, 1000, Colores.Rojo, "123ABC", true));
                listaVehiculos.Add(new Vehiculo(2, Marcas.Scania, 1500, Colores.Gris, "456FFF", true));
                listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "789SDA", true));
                listaVehiculos.Add(new Vehiculo(4, Marcas.Volkswagen, 500, Colores.Azul, "012AAA", true));
                listaVehiculos.Add(new Vehiculo(5, Marcas.Iveco, 1200, Colores.Blanco, "344SSS", true));
            }
        }
      /*  public static void AgregarVehiculos()
        {
            listaVehiculos.Add(new Vehiculo(1, Marcas.Fiat, 1000, Colores.Rojo, "123ABC", true));
            listaVehiculos.Add(new Vehiculo(2, Marcas.Scania, 1500, Colores.Gris, "456FFF", true));
            listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "789SDA", true));
            listaVehiculos.Add(new Vehiculo(4, Marcas.Volkswagen, 500, Colores.Azul, "012AAA", true));
            listaVehiculos.Add(new Vehiculo(5, Marcas.Iveco, 1200, Colores.Blanco, "344SSS",true));
        }*/
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
                if (cargaSoportada >= kilos && vehiculo.Estado==true)
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
        public static bool VerificarFormatoPatente(string patenteIngresada)
        {
            bool retorno = true;
            // Verificar longitud del string
            if (patenteIngresada.Length != 6)
            {
                retorno = false;
            }

            // Verificar caracteres individualmente
            for (int i = 0; i < patenteIngresada.Length; i++)
            {
                if (i < 3 && !char.IsDigit(patenteIngresada[i])) // Los primeros tres caracteres deben ser dígitos
                {
                    retorno = false;
                }
                if (i >= 3 && !char.IsLetter(patenteIngresada[i])) // Los últimos tres caracteres deben ser letras
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        public static bool VerificarExistenciaPatente(string patenteIngresada)
        {
            bool retorno = true;
            foreach (Vehiculo vehiculo in ListaVehiculos)
            {
                if (vehiculo.Patente == patenteIngresada)
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        // retona 0 todo bien || 1 esta mal el formato || 2 ya existe la patente
        public static int VerificarPatente(string patenteIngresada)
        {
            int retorno = 0;
            string patenteAuxiliar = patenteIngresada.ToUpper();
            if (VerificarFormatoPatente(patenteAuxiliar) != true)
            {
                retorno = 1;
            }
            else
            {
                if (VerificarExistenciaPatente(patenteAuxiliar) !=true)
                {
                    retorno = 2;
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
        public static Vehiculo BuscarVehiculo(int idCliente)
        {
            Vehiculo vehiculo = null;
            //int contador = 0;
            foreach (Vehiculo vehiculoAuxiliar in ListaVehiculos)
            {
                if (vehiculoAuxiliar.IdVehiculo== idCliente)
                {

                    vehiculo = vehiculoAuxiliar;
                    break;
                }
                // contador = contador + 1;
            }
            //indice = contador;
            return vehiculo;
        }

    }
}
