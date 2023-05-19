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
            if (Repositorio_Viajes.Repo_Viajes.CrearViaje(int.Parse(txt_IdCliente.Text), txt_Nombre.Text, txt_DireccionSalida.Text,
                cbo_Provincias.Text, (float)nup_Kilos.Value, dtp_FechaDeViaje.Value.Date))
            {
                viajeAux = Repositorio_Viajes.Repo_Viajes.BuscarInstanciaId(Repositorio_Viajes.Repo_Viajes.CalcularId() - 1);
                MessageBox.Show("VIAJE CONFIRMADO\n" + viajeAux.ToString());
                Frm_Cliente_Menu anterior = new Frm_Cliente_Menu();
                anterior.usuarioInstanciado = clienteInstanciado;
                this.Close();
                anterior.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
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
