using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Vehiculos : Interfaz_Padre <Vehiculo>
    {
        private static List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private readonly static Repositorio_Vehiculos repo_Vehiculos = new Repositorio_Vehiculos();
        public static List<Vehiculo> ListaVehiculos { get => listaVehiculos; set => listaVehiculos = value; }

        public static Repositorio_Vehiculos Repo_Vehiculos => repo_Vehiculos;
        /// <summary>
        /// Hardcodeo de vehiculos
        /// </summary>
        public  void Agregar()
        {
            if(ListaVehiculos.Count==0) 
            {
               /* listaVehiculos.Add(new Vehiculo(1, Marcas.Fiat, 1000, Colores.Rojo, "123ABC", true));
                listaVehiculos.Add(new Vehiculo(2, Marcas.Scania, 1500, Colores.Gris, "456FFF", true));
                listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "789SDA", true));
                listaVehiculos.Add(new Vehiculo(4, Marcas.Volkswagen, 500, Colores.Azul, "012AAA", true));
                listaVehiculos.Add(new Vehiculo(5, Marcas.Iveco, 1200, Colores.Blanco, "344SSS", true));*/
            }
        }
        /// <summary>
        /// Calcular el id de un nuevo vehiculo segun el ultimo 
        /// </summary>
        /// <returns></returns>
        public  int CalcularId()
        {
            int retorno;
            Vehiculo ultimo = ListaVehiculos[ListaVehiculos.Count - 1];
            retorno = (ultimo.IdVehiculo) + 1;
            return retorno;
        }


        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public  Vehiculo BuscarInstanciaId(int idCliente)
        {
            Vehiculo vehiculo = null;
            //int contador = 0;
            foreach (Vehiculo vehiculoAuxiliar in ListaVehiculos)
            {
                if (vehiculoAuxiliar.IdVehiculo == idCliente)
                {

                    vehiculo = vehiculoAuxiliar;
                    break;
                }
            }
            return vehiculo;

        }
        /// <summary>
        /// A partir de un determinado peso y luego teniendo en cuenta la fecha de viaje, se busca retornar el
        /// id de un vehiculo disponible
        /// </summary>
        /// <param name="kilos"></param>kilos a transportar
        /// <param name="fechaSolicitada"></param>fecha en la que se realizaria el viaje
        /// <returns></returns>
        public static int RetornarVehiculoDisponible(float kilos, DateTime fechaSolicitada)
        {
            float cargaSoportada;
            Viaje viajeAxuliar;
            //vehiculos aptos para transportar la cantidad de kilos.
            int retorno = 0;
            List <Vehiculo>listaVehiculosAuxiliar = Conexion_SQL.ObtenerVehiculos("vehiculos");
            foreach (Vehiculo vehiculo in listaVehiculosAuxiliar)
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
        /// <summary>
        /// Baja logica para la instancia
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public  Vehiculo DarDeBaja(string ID)
        {
            /*Vehiculo vehiculo = BuscarInstanciaId(ID);
            if (vehiculo.Estado == true)
            {
                vehiculo.Estado = false;
            }*/
            return null;
        }
    }
}
