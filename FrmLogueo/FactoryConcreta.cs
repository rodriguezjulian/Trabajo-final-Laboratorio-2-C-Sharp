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
            Form formulario=null;
            Usuario usuarioAuxiliar=null;
         
            Sistema.PoblarListas();
            usuarioAuxiliar = Sistema.ValidarUsuario(usuario);
            if (usuarioAuxiliar != null && usuarioAuxiliar is Empleado)
            {
                 Frm_Empleado_Menu menuEmpleado = new Frm_Empleado_Menu();//INSTANCIO AL EMPLEADO
                menuEmpleado.UsuarioInstanciado = usuarioAuxiliar;
                formulario =menuEmpleado;
            }
            else
            {
                if (usuarioAuxiliar != null && usuarioAuxiliar is Cliente)
                {
                     Frm_Cliente_Menu menuCliente = new Frm_Cliente_Menu();//INSTANCIO AL CLIENTE
                    menuCliente.UsuarioInstanciado = usuarioAuxiliar;
                    formulario= menuCliente;
                }
            }
            return formulario;
        }
    }
}
