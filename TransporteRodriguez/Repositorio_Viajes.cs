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

        public static List<Viaje> ListaViajes { get => listaViajes; set => listaViajes = value; }

        public override void Agregar()
        {
            if (ListaViajes.Count==0)
            {
                ListaViajes.Add(new Viaje(1, "María García", "Calle 25 de Mayo 5678",
                "Salta", 200, 10000, 1, new DateTime(2023, 08, 11, 0, 0, 0)));
                ListaViajes.Add(new Viaje(2, "Javier Díaz", "Av. Córdoba 6789",
                "Corrientes", 1800, 10500, 5, new DateTime(2024, 05, 11, 0, 0, 0)));//ACA SIEMPRE SE GUARDA CON HORA MINUTO SEGUNDO 
                ListaViajes.Add(new Viaje(3, "Laura Fernández", "Av. Santa Fe 2468",
               "Santa Fe", 20, 10500, 3, new DateTime(2023, 08, 11, 0, 0, 0)));
                ListaViajes.Add(new Viaje(2, "Javier Díaz", "Av. Córdoba 6789",
                "Corrientes", 1800, 10500, 5, new DateTime(2021, 05, 11, 0, 0, 0)));
            }
        }
      /*  public static void AgregarViajes()
        {
            ListaViajes.Add(new Viaje(1, "María García", "Calle 25 de Mayo 5678",
            "Salta", 200, 10000, 1, new DateTime(2023, 08, 11, 0, 0, 0)));
            ListaViajes.Add(new Viaje(2, "Javier Díaz", "Av. Córdoba 6789",
            "Corrientes", 1800, 10500, 5, new DateTime(2024, 05, 11, 0, 0, 0)));//ACA SIEMPRE SE GUARDA CON HORA MINUTO SEGUNDO 
            ListaViajes.Add(new Viaje(3, "Laura Fernández", "Av. Santa Fe 2468",
           "Santa Fe", 20, 10500, 3, new DateTime(2023, 08, 11, 0, 0, 0)));
            ListaViajes.Add(new Viaje(2, "Javier Díaz", "Av. Córdoba 6789",
            "Corrientes", 1800, 10500, 5, new DateTime(2021, 05, 11, 0, 0, 0)));
        }*/
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
        public static float calcularPrecioViaje(int provincia, float kilosTransportados)
        {
            float precio = 0;
            switch (provincia)
            {
                case 0:
                    precio = (kilosTransportados * 200) + 4000;
                    break;
                case 1:
                    precio = (kilosTransportados * 200) + 6000;
                    break;
                case 2:
                    precio = (kilosTransportados * 200) + 8000;
                    break;
            }
            return precio;
        }
       /* public static bool buscarViaje(int idViaje, out Viaje viajeEncontrado)
        {
            viajeEncontrado = null;
            bool retorno = false;

            foreach (Viaje viajeAxuliar in ListaViajes)
            {
                if (viajeAxuliar.IdViaje == idViaje)
                {
                    viajeEncontrado = viajeAxuliar;
                    retorno = true;
                    break;
                }

            }
            return retorno;
        }*/
        public override Viaje BuscarInstancia( int idViaje)
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


       /* public static int CalcularIdViaje()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje) + 1;
            return retorno;
        }*/
        public override int CalcularId()
        {
            int retorno;
            Viaje viajeUltimo = ListaViajes[ListaViajes.Count - 1];
            retorno = (viajeUltimo.IdViaje) + 1;
            return retorno;
        }

    }
}
