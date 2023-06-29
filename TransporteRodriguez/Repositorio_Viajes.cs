using Enumerado;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Viajes : Interfaz_Padre <Viaje>
    {
        private static List<Viaje> listaViajes = new List<Viaje>();
        private readonly static Repositorio_Viajes repo_Viajes = new Repositorio_Viajes();
        public static List<Viaje> ListaViajes { get => listaViajes; set => listaViajes = value; }

        public static Repositorio_Viajes Repo_Viajes => repo_Viajes;

        /// <summary>
        /// Verificar si existe un vehiculo disponible en la fecha dada
        /// </summary>
        /// <param name="viajeAxuliar"></param>
        /// <returns></returns>
        public static bool VerificarDisponibilidadFecha(Viaje viajeAxuliar)
        {
            bool retorno = true;
            List <Viaje> listaViajesAuxiliar = Conexion_SQL.ObtenerViajes("viajes");
            if (viajeAxuliar.FechaViaje > DateTime.Today)
            {
                foreach (Viaje viajesReservados in listaViajesAuxiliar)
                {
                    if (viajesReservados == viajeAxuliar)
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("ERROR, El plazo minimo de reserva es un dia antes. \nLa fecha mas cercana seria mañana en caso que existan vehiculos disponibles.");
            }

            return retorno;
        }
        /// <summary>
        /// Segun el destino y los kg transportados, se calculara el precio
        /// </summary>
        /// <param name="provincia"></param>
        /// <param name="kilosTransportados"></param>
        /// <returns></returns>
        public float calcularPrecioViaje(string provincia, float kilosTransportados)
        {
            float precio = 0;
            switch (provincia.ToLower())
            {
                case "santa fe":
                    precio = (kilosTransportados * 200) + 4000;
                    break;
                case "corrientes":
                    precio = (kilosTransportados * 200) + 6000;
                    break;
                case "misiones":
                    precio = (kilosTransportados * 200) + 8000;
                    break;
            }
            return precio;
        }
        public  Viaje BuscarInstanciaId( int idViaje)
        {
            Viaje viajeEncontrado = null;
            List <Viaje> listaViajesAux= Conexion_SQL.ObtenerViajes("viajes");

            foreach (Viaje viajeAxuliar in listaViajesAux)
            {
                if (viajeAxuliar.IdViaje == idViaje)
                {
                    viajeEncontrado = viajeAxuliar;
                    break;
                }
            }
            return viajeEncontrado;
        }
        public Viaje BuscarInstancia(Viaje usuarioUno)
        {
            List<Viaje> listaViajes = Conexion_SQL.ObtenerViajes("viajes");
            Viaje retorno = null;
            foreach (Viaje viaje in listaViajes)
            {
                if (viaje == usuarioUno && viaje.Estado == true)
                {
                    retorno = viaje;
                    break;
                }
            }
            return retorno;
        }


        /// <summary>
        /// Se creara una nueva instancia siempre y cuando se tenga un vehiculo disponible que pueda llevar esa cantidad de kg en esa fecha
        /// indicada, para esto nos apoyaremos en el metodo Repositorio_Vehiculos.RetornarVehiculoDisponible.
        /// </summary>
        /// <param name="idCliente"></param> segun usuario logueado se obtiene mediante la propiedad y se pasa como parametro
        /// <param name="nombre"></param>segun usuario logueado se obtiene mediante la propiedad y se pasa como parametro
        /// <param name="direccionSalida"></param>segun usuario logueado se obtiene mediante la propiedad y se pasa como parametro
        /// <param name="provinciaDestino"></param>Elegida por el usuario desde un combo box
        /// <param name="cargaKg"></param>Seleccionado por el usuario desde un numericUpDown
        /// <param name="fecha"></param>Seleccionado por el usuario desde un dateTimePicker
        /// <returns></returns>
        public bool CrearViaje(string idCliente,string nombre, string direccionSalida, string provinciaDestino, string cargaKg, DateTime fecha)
        {
            bool retorno = false;
            
            int idEntero=1;
            float cargaKgFloat;
            if (Validaciones.VerificarkgIngresado(cargaKg, out cargaKgFloat) == true &&Validaciones.VerificarIdIngresado(idCliente,out idEntero) == true  
                && Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKgFloat, fecha) != 0) 
            {
                retorno = true;

               Viaje viajeAux =new Viaje(idEntero, nombre, direccionSalida, provinciaDestino, cargaKgFloat,
               calcularPrecioViaje(provinciaDestino, cargaKgFloat), Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKgFloat, fecha), fecha.Date,true);
               Conexion_SQL.Insertar(viajeAux, "viajes");
              
            }
            return retorno;
        }
        /// <summary>
        /// Se modificara una instancia siempre y cuando se tenga un vehiculo disponible que pueda llevar esa cantidad de kg en esa fecha
        /// indicada, para esto nos apoyaremos en el metodo Repositorio_Vehiculos.RetornarVehiculoDisponible y ademas setearemos el IdVehiculo del viaje
        /// en 0 al menos momentaneamete ya que por ejemplo si cambiasemos destino, nos podria llevar el mismo vehiculo pero si no liberamos a IdVehiculo
        /// antes, seguira ligado al anterior viaje.
        /// </summary>
        /// <param name="idViaje"></param>segun usuario logueado se obtiene mediante la propiedad y se pasa como parametro
        /// <param name="cliente"></param>segun usuario logueado se obtiene mediante la propiedad y se pasa como parametro
        /// <param name="fecha"></param>Seleccionado por el usuario desde un dateTimePicker
        /// <param name="kg"></param>Seleccionado por el usuario desde un numericUpDown
        /// <param name="destino"></param>Elegida por el usuario desde un combo box
        /// <param name="viaje"></param>Se devuelve la direccion del viaje para que se pueda mostrar un resumen de como quedo el viaje
        /// a traves de un MessageBox.Show y un string builder creado con los datos del viaje
        /// <returns></returns>
        public bool ModificarViaje(string idViaje,Cliente cliente, DateTime fecha, string kg ,string destino, out Viaje viaje)
        {
            bool retorno = false;
            Viaje viajeAux=null;
            viaje=null;
            int idViajeEntero;
            float kgF;
            if (Validaciones.VerificarIdIngresado(idViaje, out idViajeEntero))
            {
                viajeAux = BuscarInstanciaId(idViajeEntero);
                if (viajeAux is not null && cliente.IdCliente == viajeAux.IdCliente)
                {
                    if (viajeAux.FechaViaje < DateTime.Today.AddDays(+1))
                    {
                        throw new Exception("Error, solo puede modificar o dar de baja viajes que aun no se han realizado.");
                    }
                    else
                    {
                        if (Validaciones.VerificarkgIngresado(kg, out kgF) && Repositorio_Vehiculos.RetornarVehiculoDisponible(kgF, fecha) != 0)
                        {
                            if (destino != "Santa fe" && destino != "Corrientes" && destino != "Misiones")
                            {
                                throw new Exception("Error, debe ingresar un destino valido:\n Santa fe\nCorrientes\nMisiones");
                            }
                            else
                            {
                                if (fecha < DateTime.Today)
                                {
                                    throw new Exception("ERROR, Debe elegir una fecha valida.");
                                }
                                else
                                {
                                    viajeAux.IdVehiculo = Repositorio_Vehiculos.RetornarVehiculoDisponible(kgF, fecha);
                                    viajeAux.Precio = calcularPrecioViaje(destino, kgF);
                                    viajeAux.FechaViaje = fecha;
                                    viajeAux.KilosATransportar = kgF;
                                    viajeAux.ProvinciaDestino = destino;
                                    viaje = viajeAux;
                                    retorno = true;
                                    Conexion_SQL.Modificar(viaje, "viajes");
                                }
                            }
                        }
                    }  
                }
                else
                {
                    //COMO LOS METODOS TIENEN SUS PROPIAS EXCEPCIONES, SOLO HAGO ESTA EXCEPCION cliente.IdCliente == viajeAux.IdCliente
                    throw new Exception("ERROR, El ID de viaje no corresponde a usted.");
                }
            }
            return retorno;
        }

        public  Viaje DarDeBaja(string ID, Cliente cliente)
        {
            int idEntero;
            if (Validaciones.VerificarIdIngresado(ID, out idEntero))
            {
                Viaje viaje = BuscarInstanciaId(idEntero);
                if (viaje is null)
                {
                    throw new Exception("ERROR, El ID ingresado no corresponde a ningun viaje.");
                }
                else
                {
                    if(cliente.IdCliente != viaje.IdCliente)
                    {
                        throw new Exception("ERROR, El ID de viaje no corresponde a usted.");
                    }
                    else
                    {
                        if (viaje.FechaViaje < DateTime.Today.AddDays(+1))
                        {
                            throw new Exception("Error, solo puede modificar o dar de baja viajes que aun no se han realizado.");
                        }
                        else
                        {
                            Conexion_SQL.DarDeBaja(idEntero, "viajes", viaje);
                        }
                    }
                }
            }
            return null;
        }
        public void GuardarViajes(DateTime limiteInferior, DateTime limiteSuperior, string ruta)
        {
            List<Viaje> listaViajes = Conexion_SQL.ObtenerViajes("viajes");
            List<Viaje> listaAux= new List<Viaje>();
            if (limiteInferior < limiteSuperior || limiteInferior == limiteSuperior)
            {

                foreach (Viaje viaje in listaViajes)
                {
                    if (viaje.FechaViaje >= limiteInferior && viaje.FechaViaje <= limiteSuperior)
                    {
                        listaAux.Add(viaje);    
                    }
                }
                Serializadora<Viaje>.EscribirXML(ruta + ".xml", listaAux);
            }
            else
            {
                throw new Exception("ERROR, Debe ingresar las fechas con coherencia en tanto a limite inferior y mayor.");
            }
        }
        public List<Viaje> LeerInforme(string ruta)
        {
            List<Viaje> listaViajes = Serializadora<Viaje>.LeerXML(ruta);
            return listaViajes;
        }
        public bool FiltrarViajeActivo(Viaje viaje)
        {
            bool retorno = false;
            if(viaje.Estado)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool FiltrarViajeInactivo(Viaje viaje)
        {
            bool retorno = false;
            if (viaje.Estado==false)
            {
                retorno = true;
            }
            return retorno;
        }
        public bool FiltrarViajeRealizado(Viaje viaje)
        {
            bool retorno = false;
            if (viaje.FechaViaje < DateTime.Now && viaje.Estado)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
