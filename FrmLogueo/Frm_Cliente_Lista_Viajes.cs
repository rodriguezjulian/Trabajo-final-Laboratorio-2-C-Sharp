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
    public partial class Frm_Cliente_Lista_Viajes : Form
    {
        Cliente cliente;
        public Frm_Cliente_Lista_Viajes()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmListarViajesCliente_Load(object sender, EventArgs e)
        {
            List<Viaje> viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dataGridView1.DataSource = viajesCliente;
            lbl_NombreCliente.Text = cliente.Nombre;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
