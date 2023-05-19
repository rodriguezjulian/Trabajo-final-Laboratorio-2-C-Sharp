using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Viajes : Repositorio_Padre
    {
        private static List<Viaje> listaViajes = new List<Viaje>();
        private readonly static Repositorio_Viajes repo_Viajes = new Repositorio_Viajes();
        public static List<Viaje> ListaViajes { get => listaViajes; set => listaViajes = value; }

        public static Repositorio_Viajes Repo_Viajes => repo_Viajes;
        /// <summary>
        /// Hardcodeo de Viajes
        /// </summary>
        public override void Agregar()
        {
            if (ListaViajes.Count==0)
            {
                ListaViajes.Add(new Viaje(2,1, "María García", "Calle 25 de Mayo 5678",
                "Misiones", 200, 10000, 1, new DateTime(2021, 08, 11, 0, 0, 0)));
                ListaViajes.Add(new Viaje(7,2, "Javier Díaz", "Av. Córdoba 6789",
                "Corrientes", 1800, 10500, 5, new DateTime(2022, 05, 11, 0, 0, 0)));//ACA SIEMPRE SE GUARDA CON HORA MINUTO SEGUNDO 
                ListaViajes.Add(new Viaje(6,3, "Laura Fernández", "Av. Santa Fe 2468",
               "Santa Fe", 20, 10500, 3, new DateTime(2023, 08, 11, 0, 0, 0)));
                ListaViajes.Add(new Viaje(7,4, "Javier Díaz", "Av. Córdoba 6789",
                "Corrientes", 1800, 10500, 5, new DateTime(2024, 05, 11, 0, 0, 0)));
            }
        }
        /// <summary>
        /// Verificar si existe un vehiculo disponible en la fecha dada
        /// </summary>
        /// <param name="viajeAxuliar"></param>
        /// <returns></returns>
        public static bool VerificarDisponibilidadFecha(Viaje viajeAxuliar)
        {
            bool retorno = true;
            foreach (Viaje viajesReservados in ListaViajes)
            {
                if (viajesReservados == viajeAxuliar)
                {
                    retorno = false;
                    break;
                }
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
        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>
        /// <param name="idViaje"></param>
        /// <returns></returns>
        public override Viaje BuscarInstanciaId( int idViaje)
        {
            Viaje viajeEncontrado = null;


            foreach (Viaje viajeAxuliar in ListaViajes)
            {
                if (viajeAxuliar.IdViaje == idViaje)
                {
                    viajeEncontrado = viajeAxuliar;
                    break;
                }
            }
            
            return viajeEncontrado;
        }
        /// <summary>
        /// Calcular el id de un viaje segun el ultimo existente
        /// </summary>
        /// <returns></returns>
        public override int CalcularId()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje) + 1;
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
        public bool CrearViaje(int idCliente,string nombre, string direccionSalida, string provinciaDestino, float cargaKg, DateTime fecha)
        {
            bool retorno = false;
            if (Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKg, fecha) != 0) 
            {
                retorno = true;
                ListaViajes.Add(new Viaje(idCliente, CalcularId(), nombre, direccionSalida, provinciaDestino, cargaKg,
                calcularPrecioViaje(provinciaDestino, cargaKg), Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKg, fecha), fecha.Date));
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
        public bool ModificarViaje(int idViaje,Cliente cliente, DateTime fecha, float kg ,string destino, out Viaje viaje)
        {
            bool retorno = false;
            Viaje viajeAux=null;
            int idVehiculoOriginal;
            viaje=null;
            viajeAux =BuscarInstanciaId(idViaje);
            //ESTO LO HAGO PORQUE CUANDO QUIERO MODIFICAR EL DESTINO POSIBLEMENTE SEA EL MISMO CAMION EL QUE HAGA EL VIAJE
            //SI NO LO LIBERO AL MENOS MOMENTANEAMENTE, SIEMPRE TENDRA OCUPADA LA FECHA.
            idVehiculoOriginal = viajeAux.IdVehiculo;
            viajeAux.IdVehiculo = 0;
            if (Repositorio_Vehiculos.RetornarVehiculoDisponible(kg, fecha)!=0)
            {
                retorno = true;
                viaje = viajeAux;
                viajeAux.IdVehiculo = Repositorio_Vehiculos.RetornarVehiculoDisponible(kg, fecha);
                viajeAux.Precio = calcularPrecioViaje(destino, kg);
                viajeAux.FechaViaje = fecha;
                viajeAux.KilosATransportar = kg;
                viajeAux.ProvinciaDestino = destino;
            }
            if (retorno==false)
            {
                viajeAux.IdVehiculo = idVehiculoOriginal;
            }
            
            return retorno;
        }
        public override Viaje DarDeBaja(int ID)
        {
            Viaje viaje = BuscarInstanciaId(ID);
            ListaViajes.Remove(viaje);
            return viaje;
        }
    }
}
