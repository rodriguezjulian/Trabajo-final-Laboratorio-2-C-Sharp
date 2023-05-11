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

        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }
        private static Frm_Login login;
        public static Frm_Login Login { get => login; set => login = value; }

        public Frm_Empleado_Menu()
        {
            InitializeComponent();
        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTACIO EL FORMULARIO SIGUIENTE
            Frm_Empleado_Alta_Cliente frmAltaCliente = new Frm_Empleado_Alta_Cliente();
            frmAltaCliente.EmpleadoInstanciado = usuarioInstanciado;
            //DialogResult confirmacion
            if (frmAltaCliente.ShowDialog() == DialogResult.OK) //cuando mostramos con ShowDialog damos foco a ese formulario
            {

            }
        }
        private void FrmMenuEmpleado_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = UsuarioInstanciado.Nombre;
        }
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Empleados_Lista_Vehiculos frmListarVehiculos = new Frm_Empleados_Lista_Vehiculos();
            frmListarVehiculos.UsuarioInstanciado = usuarioInstanciado;
            this.Close();
            frmListarVehiculos.Show();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            login.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta_Cliente frm_Empleado_Alta_Cliente = new Frm_Empleado_Alta_Cliente();
            frm_Empleado_Alta_Cliente.TopLevel = false;
            pnl_Padre.Controls.Add(frm_Empleado_Alta_Cliente);
            frm_Empleado_Alta_Cliente.Dock = DockStyle.Fill;
            //frm_Empleado_Alta_Cliente.EmpleadoInstanciado = usuarioInstanciado;
            frm_Empleado_Alta_Cliente.Show();
        }

        private void tmr_Menu_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
/*
             frm_Empleado_Alta_Cliente.TopLevel = false;
            frm_Empleado_Alta_Cliente.Dock = DockStyle.Fill;
            this. pnl_Padre.Controls.Add(fh);
            this. pnl_Padre.Tag = fh;
            frm_Empleado_Alta_Cliente();
 
 */