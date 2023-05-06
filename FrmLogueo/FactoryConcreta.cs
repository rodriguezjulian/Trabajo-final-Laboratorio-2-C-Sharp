using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporteRodriguez;

namespace WF_TransporteRodriguez
{
    public class FactoryConcreta : FactoryCreador
    {
        public override Form CrearFormulario(Usuario usuario)
        {
            Form? formulario=null;
            Usuario? usuarioAuxiliar=null;
            usuarioAuxiliar = Sistema.ValidarUsuario(usuario);
            if (usuarioAuxiliar != null && usuarioAuxiliar is Empleado)
            {
                 FrmMenuEmpleado menuEmpleado = new FrmMenuEmpleado();//INSTANCIO AL EMPLEADO
                menuEmpleado.UsuarioInstanciado = usuarioAuxiliar;
                formulario =menuEmpleado;
            }
            else
            {
                if (usuarioAuxiliar != null && usuarioAuxiliar is Cliente)
                {
                     FrmMenuCliente menuCliente = new FrmMenuCliente();//INSTANCIO AL CLIENTE
                    menuCliente.UsuarioInstanciado = usuarioAuxiliar;
                    formulario= menuCliente;
                }
            }
            return formulario;
        }
    }
}
