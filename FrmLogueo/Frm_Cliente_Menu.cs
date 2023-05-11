using FrmLogueo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransporteRodriguez;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Cliente_Menu : Form
    {
        public Usuario usuarioInstanciado;
        Cliente clienteInstanciado;
        public Frm_Cliente_Menu()
        {
            InitializeComponent();
        }
        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Form anterior = new Frm_Login(); // Crea una instancia del formulario anterior
            anterior.ShowDialog(); // Muestra el formulario anterior como diálogo
            this.Close(); // Cierra el formulario actual
        }

        private void reservarViajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Cliente_Alta_Viaje frmViaje = new Frm_Cliente_Alta_Viaje();
            frmViaje.ClienteInstanciado = usuarioInstanciado;
            frmViaje.MdiParent = this;
            frmViaje.Dock = DockStyle.Fill;
            frmViaje.Show();
        }

        private void listarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cliente_Lista_Viajes frmListarViajesCliente = new Frm_Cliente_Lista_Viajes();
            frmListarViajesCliente.Cliente = clienteInstanciado;
            frmListarViajesCliente.MdiParent = this;
            frmListarViajesCliente.Dock = DockStyle.Fill;
            frmListarViajesCliente.Show();

        }

        private void FrmMenuCliente_Load(object sender, EventArgs e)
        {
            clienteInstanciado = Sistema.BuscarCliente(usuarioInstanciado);

        }

        private void modificarViajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Cliente_Modificacion_Viaje frmModificarViajeCliente = new Frm_Cliente_Modificacion_Viaje();
            frmModificarViajeCliente.Cliente = clienteInstanciado;
            frmModificarViajeCliente.MdiParent = this;
            frmModificarViajeCliente.Dock = DockStyle.Fill;
            frmModificarViajeCliente.Show();
        }

        private void cancelarViajeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Cliente_Cancelacion_Viaje frmCancelarViajeCliente = new Frm_Cliente_Cancelacion_Viaje();
            frmCancelarViajeCliente.Cliente = clienteInstanciado;
            frmCancelarViajeCliente.MdiParent = this;
            frmCancelarViajeCliente.Dock = DockStyle.Fill;
            frmCancelarViajeCliente.Show();
        }
        private void misViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cliente_Datos frmDatos = new Frm_Cliente_Datos();
            frmDatos.Cliente = clienteInstanciado;
            frmDatos.MdiParent = this;
            frmDatos.Dock = DockStyle.Fill;
            frmDatos.Show();
        }
    }
}
