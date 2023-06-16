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
    public partial class Frm_Empleado_Lista_Viajes : Form
    {
        List<Viaje> listaAuxiliar;
        public Frm_Empleado_Lista_Viajes()
        {
            InitializeComponent();
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_Empleado_Lista_Viajes_Load(object sender, EventArgs e)
        {
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.Estado == true);
            OrganizarDataGridViajes(listaAuxiliar);
        }
        public void OrganizarDataGridViajes(List<Viaje> viajesCliente)
        {

            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesCliente;

            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdViaje",
                HeaderText = "ID",
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

        private void btn_ViajesRealizados_Click(object sender, EventArgs e)
        {
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.FechaViaje < DateTime.Now && viaje.Estado == true);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(listaAuxiliar);
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListaViajes.Columns.Clear();
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.Estado == true);
            OrganizarDataGridViajes(listaAuxiliar);
        }

        private void btn_ViajesCancelados_Click(object sender, EventArgs e)
        {
            dtg_ListaViajes.Columns.Clear();
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.Estado == false);
            OrganizarDataGridViajes(listaAuxiliar);
        }
    }
}
