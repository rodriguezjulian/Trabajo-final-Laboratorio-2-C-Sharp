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
    public partial class FrmListarViajesCliente : Form
    {
        Cliente cliente;
        public FrmListarViajesCliente()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmListarViajesCliente_Load(object sender, EventArgs e)
        {
            List<Viaje> viajesCliente = Sistema.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dataGridView1.DataSource = viajesCliente;
        }
    }
}
