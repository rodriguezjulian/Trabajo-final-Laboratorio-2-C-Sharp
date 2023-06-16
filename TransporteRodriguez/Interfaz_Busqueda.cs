using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal interface Interfaz_Busqueda<T,M>
    {
        public T BuscarInstancia(M usuarioUno);
    }
}
