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
        //Este metodo es clave para despues poder comparar la fecha ingresada con la existente
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
        public override int CalcularId()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje) + 1;
            return retorno;
        }
        public override Viaje DarDeBaja(int ID)
        {
            Viaje viaje = BuscarInstanciaId(ID);
            ListaViajes.Remove(viaje);
            return viaje;
        }

        public bool CrearViaje(int idCliente,string nombre, string direccionSalida, string provinciaDestino, float cargaKg, DateTime fecha)
        {
            bool retorno = false;
            if (Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKg, fecha) != 0) 
            {
                retorno = true;
                Repositorio_Viajes.ListaViajes.Add(new Viaje(idCliente, CalcularId(), nombre, direccionSalida, provinciaDestino, cargaKg,
                calcularPrecioViaje(provinciaDestino, cargaKg), Repositorio_Vehiculos.RetornarVehiculoDisponible(cargaKg, fecha), fecha.Date));
            }
            return retorno;
        }
        public bool ModificarViaje(int idViaje,Cliente cliente, DateTime fecha, float kg ,string destino, out Viaje viaje)
        {
            bool retorno = false;
            Viaje viajeAux=null;
            int idVehiculoOriginal;
            viaje=null;
            viajeAux =BuscarInstanciaId(idViaje);
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
            //ESTO LO HAGO PORQUE CUANDO QUIERO MODIFICAR EL DESTINO POSIBLEMENTE SEA EL MISMO CAMION EL QUE HAGA EL VIAJE
            //SI NO LO LIBERO AL MENOS MOMENTANEAMENTE, SIEMPRE TENDRA OCUPADA LA FECHA.
            if (retorno==false)
            {
                viajeAux.IdVehiculo = idVehiculoOriginal;
            }
            
            return retorno;
        }
    }
}
