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
            List<Viaje> viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            lbl_NombreCliente.Text = cliente.Nombre;
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }

        private void pic_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_ViajesRealizados_Click(object sender, EventArgs e)
        {
            List<Viaje> viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre && viaje.FechaViaje < DateTime.Now);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }


        private void btn_ViajesTodos_Click(object sender, EventArgs e)
        {
            List<Viaje> viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }
        private void btn_ViajesPendientes_Click(object sender, EventArgs e)
        {
            List<Viaje> viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre && viaje.FechaViaje > DateTime.Now);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }
        public void OrganizarDataGridViajes(List<Viaje> viajesCliente)
        {

            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesCliente;

            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdViaje",
                HeaderText = "ID VIAJE",
                DisplayIndex = 0
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FechaViaje",
                HeaderText = "Fecha",
                DisplayIndex = 1
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "nombreCliente",
                HeaderText = "Nombre",
                DisplayIndex = 2
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionSalida",
                HeaderText = "Salida",
                DisplayIndex = 3
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProvinciaDestino",
                HeaderText = "Destino",
                DisplayIndex = 4
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DisplayIndex = 5
            });
        }


    }
}
