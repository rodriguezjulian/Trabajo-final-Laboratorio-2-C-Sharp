using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporteRodriguez;

namespace WF_TransporteRodriguez
{
    public abstract class FactoryCreador
    {
        public abstract Form CrearFormulario(Usuario usario);
    }
}
