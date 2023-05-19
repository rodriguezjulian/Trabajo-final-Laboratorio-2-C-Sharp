using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public abstract class Repositorio_Padre
    {
        /// <summary>
        /// Poblar lista por lista con datos hardcodeados
        /// </summary>
        public abstract void Agregar();
        //public abstract void Eliminar();
        /// <summary>
        /// Calcular el atributo id de nuevas instancias
        /// </summary>
        /// <returns></returns>
        public abstract int CalcularId();

        /// <summary>
        /// Devolver direccion de memoria de instancia buscandola con su id
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public abstract object BuscarInstanciaId(int i);

        /// <summary>
        /// Baja logica / eliminacion de instancias desde su id
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public abstract object DarDeBaja(int i);
        // public abstract string Mostrar(object uno);
        /// <summary>
        /// Buscar instancia utilizando una sobre carga en el ==
        /// </summary>
        /// <param name="uno"></param>
        /// <returns></returns>
        public virtual object BuscarInstancia(object uno)
        {
            return null;
        }


    }
}
