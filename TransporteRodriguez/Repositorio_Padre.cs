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
        public virtual object BuscarInstancia(object uno)
        {
            return null;
        }
        public virtual object BuscarInstancia(int i)
        {
            return null;
        }

    }
}
