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
    public partial class Frm_Cliente_Alta_Viaje : Form
    {
        Usuario clienteInstanciado;
        Cliente cliente;
        Viaje viajeAux;

        public Frm_Cliente_Alta_Viaje()
        {
            InitializeComponent();
        }

        public Usuario ClienteInstanciado { get => clienteInstanciado; set => clienteInstanciado = value; }
        private void FrmViaje_Load(object sender, EventArgs e)
        {
            cliente = Repositorio_Clientes.Repo_Clientes.BuscarInstancia(clienteInstanciado);
            txt_Nombre.Text = cliente.Nombre;
            txt_DireccionSalida.Text = cliente.DireccionBSAS;
            cbo_Provincias.SelectedIndex = 0;
            dtp_FechaDeViaje.MinDate = DateTime.Today.AddDays(1);
            lbl_NombreClient.Text = cliente.Nombre;
            txt_IdCliente.Text = cliente.IdCliente.ToString();

        }

        private void pic_ReservarViajar_Click(object sender, EventArgs e)
        {
            try
            {
                Repositorio_Viajes.Repo_Viajes.CrearViaje(txt_IdCliente.Text, txt_Nombre.Text, txt_DireccionSalida.Text,
                  cbo_Provincias.Text, ((float)nup_Kilos.Value).ToString(), dtp_FechaDeViaje.Value.Date);
                
                MessageBox.Show("VIAJE CONFIRMADO\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region EVENTOS PARA EL MOUSE
        private void pic_ReservarViajar_MouseLeave(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Transparent;
        }

        private void pic_ReservarViajar_MouseEnter(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Transparent;
        }
        #endregion 
        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
