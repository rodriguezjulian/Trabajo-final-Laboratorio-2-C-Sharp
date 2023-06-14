using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal interface Interfaz_Padre<T>
    {
       
        public abstract void Agregar();

        public abstract int CalcularId();
  
        public abstract T BuscarInstanciaId(int i);

        public abstract T DarDeBaja(int i);
    }
}
