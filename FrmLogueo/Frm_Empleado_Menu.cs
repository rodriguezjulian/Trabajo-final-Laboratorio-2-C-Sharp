using FrmLogueo;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransporteRodriguez;
namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Menu : Form
    {
        //List<Cliente> listaEmpleados;
        Usuario usuarioInstanciado;
        static public Frm_Hora hora = new Frm_Hora();
        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }
        private static Frm_Login login;
        public static Frm_Login Login { get => login; set => login = value; }

        public Frm_Empleado_Menu()
        {
            InitializeComponent();
        }
        private void FrmMenuEmpleado_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = UsuarioInstanciado.Nombre;

            actualizarPanel(pnl_Padre, hora);
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta_Cliente frm_Empleado_Alta_Cliente = new Frm_Empleado_Alta_Cliente();
            actualizarPanel(pnl_Padre, frm_Empleado_Alta_Cliente);
        }
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Empleados_Lista_Vehiculos Frm_Empleados_Lista_Vehiculos = new Frm_Empleados_Lista_Vehiculos();
            actualizarPanel(pnl_Padre, Frm_Empleados_Lista_Vehiculos);
        }
        /* private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             Frm_Empleados_Lista_Vehiculos frmListarVehiculos = new Frm_Empleados_Lista_Vehiculos();
             frmListarVehiculos.UsuarioInstanciado = usuarioInstanciado;
             actualizarPanel(pnl_Padre, frmListarVehiculos);
             //frmListarVehiculos.Show();
         }*/
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            login.Show();
        }
        public static void actualizarPanel(Panel pln_Padre, Form hijo)
        {
            pnl_Padre.Controls.Clear();
            hijo.TopLevel = false;
            pnl_Padre.Controls.Add(hijo);
            hijo.Dock = DockStyle.Fill;
            hijo.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Listar_Clientes frm_Empleado_Listar_Clientes = new Frm_Empleado_Listar_Clientes();
            actualizarPanel(pnl_Padre, frm_Empleado_Listar_Clientes);
        }
    }

}