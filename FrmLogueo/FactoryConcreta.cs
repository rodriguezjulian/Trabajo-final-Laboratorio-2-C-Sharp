using Enumerado;
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
        Repositorio_Empleados repositorio_Empleados = new Repositorio_Empleados();
        Empleado empleadoAuxiliar;
        public override Form CrearFormulario(Usuario usuario)
        {
            Form formulario=null;
            Usuario usuarioAuxiliar=null;
         
            Sistema.PoblarListas();
            usuarioAuxiliar = Validaciones.ValidarUsuario(usuario);
            if (usuarioAuxiliar != null && usuarioAuxiliar is Empleado)
            {
                empleadoAuxiliar=repositorio_Empleados.BuscarInstancia(usuarioAuxiliar);
                if (empleadoAuxiliar.Puesto == Puestos.Sistemas)
                {
                    Frm_Admin_Menu menuEmpleado = new Frm_Admin_Menu();//INSTANCIO AL EMPLEADO
                    menuEmpleado.EmpleadoInstanciado = empleadoAuxiliar;
                    formulario = menuEmpleado;
                }
                else
                {
                    Frm_Empleado_Menu menuEmpleado = new Frm_Empleado_Menu();//INSTANCIO AL EMPLEADO
                    menuEmpleado.EmpleadoInstanciado = empleadoAuxiliar;
                    formulario = menuEmpleado;
                }
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
