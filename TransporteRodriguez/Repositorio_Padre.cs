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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        public abstract object DarDeBaja(int i);
        // public abstract string Mostrar(object uno);
        public virtual object BuscarInstancia(object uno)
        {
            return null;
        }


    }
}
