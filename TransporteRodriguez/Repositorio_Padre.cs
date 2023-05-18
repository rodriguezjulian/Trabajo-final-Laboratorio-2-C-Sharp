using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public abstract class Repositorio_Padre
    {
        public abstract void Agregar();
        //public abstract void Eliminar();
        public abstract int CalcularId();

        public abstract object BuscarInstanciaId(int i);
        public virtual object BuscarInstancia(object uno)
        {
            return null;
        }


    }
}
