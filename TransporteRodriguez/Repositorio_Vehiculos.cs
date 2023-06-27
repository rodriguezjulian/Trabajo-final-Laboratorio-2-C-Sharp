using Enumerado;
using Org.BouncyCastle.Crypto.Tls;
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

       /* public delegate int FiltarPorEstado(Vehiculo vehiculos);
        public void FiltrarVehiculos(List <Vehiculo> listavehiculos, FiltarPorEstado func)
        {
            listavehiculos.Sort(func);
        }*/

        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public  Vehiculo BuscarInstanciaId(int idCliente)
        {
            Vehiculo vehiculo = null;
           List <Vehiculo> listaVehiculosAux= Conexion_SQL.ObtenerVehiculos("vehiculos");
            //int contador = 0;
            foreach (Vehiculo vehiculoAuxiliar in listaVehiculosAux)
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
                cargaSoportada = vehiculo.Carga;
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
            if(retorno ==0)
            {
                throw new Exception("No hay vehiculo disponible en esa fecha que soporte la carga que desea transportar.");
            }
            return retorno;
        }
        /// <summary>
        /// Baja logica para la instancia
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Vehiculo DarDeBaja(string ID)
        {
            Vehiculo vehiculo = null;
            int idEntero;
            if (Validaciones.VerificarIdIngresado(ID, out idEntero))
            {
                 vehiculo = BuscarInstanciaId(idEntero);
                if (vehiculo is null)
                {
                    throw new Exception("ERROR, Vehiculo no encontrado.");
                }
                else
                {
                    if (vehiculo.Estado == false)
                    {
                        throw new Exception("ERROR, El vehiculo ya se encuentra dado de baja");
                    }
                    else
                    {
                        if(Validaciones.VerificarViajesPendientes(vehiculo))
                        {
                            Conexion_SQL.DarDeBaja(idEntero, "vehiculos", vehiculo);
                            vehiculo.Estado = false;
                        }
                    }
                }
            }
            return vehiculo;
        }
        public bool CrearVehiculo(Marcas marca,string cargaEnKg,Colores color,string patente)
        {
            bool retorno = false;
            float kgF;
            if(float.TryParse( cargaEnKg, out kgF)== false)
            {
                throw new Exception("ERROR, Ingrese un numero para KG");
            }
            else
            {
                if (Validaciones.VerificarPatente(patente))
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.MarcaVehiculo = marca;
                    vehiculo.Carga = kgF;
                    vehiculo.Color = color;
                    vehiculo.Patente = patente;
                    vehiculo.Estado = true;
                    retorno = true;
                    Conexion_SQL.Insertar(vehiculo, "vehiculos");
                }
            }
            return retorno;
        }

    }
}
