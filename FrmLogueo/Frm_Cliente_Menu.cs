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
using static System.Net.Mime.MediaTypeNames;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Cliente_Menu : Form
    {
        public Usuario usuarioInstanciado;
        Cliente clienteInstanciado;
        static Frm_Login login;
        public Frm_Cliente_Menu()
        {
            InitializeComponent();
        }
        
        public Usuario UsuarioInstanciado { get => usuarioInstanciado; set => usuarioInstanciado = value; }
        public static Frm_Login Login { get => login; set => login = value; }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Form anterior = new Frm_Login(); // Crea una instancia del formulario anterior
            anterior.ShowDialog(); // Muestra el formulario anterior como diálogo
            this.Close(); // Cierra el formulario actual
        }

        private void reservarViajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnviarMail mail=new EnviarMail();
            
            Frm_Cliente_Alta_Viaje frmViaje = new Frm_Cliente_Alta_Viaje();
            frmViaje.ClienteInstanciado = usuarioInstanciado;
            frmViaje.MdiParent = this;
            frmViaje.Dock = DockStyle.Fill;

            //frmViaje.FechaExceptionOcurred += mail.Enviarcorreo(clienteInstanciado);
           // frmViaje.FechaExceptionOcurred += Log_Errores.EscribirLogErrores;
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
            clienteInstanciado = Repositorio_Clientes.Repo_Clientes.BuscarInstancia(usuarioInstanciado);
            Frm_Hora frm_Hora = new Frm_Hora();
            frm_Hora.MdiParent = this;
            frm_Hora.Dock = DockStyle.Fill;
            frm_Hora.Show();
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            login.Show();
        }
    }
}
