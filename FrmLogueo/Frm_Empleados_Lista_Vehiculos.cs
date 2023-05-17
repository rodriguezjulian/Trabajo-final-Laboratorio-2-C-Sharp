using Enumerado;
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
    public partial class Frm_Empleados_Lista_Vehiculos : Form
    {
        List<Vehiculo> listaAxuliar;
        public Frm_Empleados_Lista_Vehiculos()
        {
            InitializeComponent();
        }
        private void FrmListarVehiculos_Load(object sender, EventArgs e)
        {

            OrganizarDataGridVehiculos(Repositorio_Vehiculos.ListaVehiculos);
        }
        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        public void OrganizarDataGridVehiculos(List<Vehiculo> ListaVehiculos)
        {
            dtg_Listar.AutoGenerateColumns = false;
            dtg_Listar.DataSource = ListaVehiculos;

            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdVehiculo",
                HeaderText = "ID",
                DisplayIndex = 0
            });

            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MarcaVehiculo",
                HeaderText = "Marca",
                DisplayIndex = 2
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CapacidadDeCarga",
                HeaderText = "Carga Soportada",
                DisplayIndex = 3
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Patente",
                HeaderText = "Patente",
                DisplayIndex = 4
            });
            dtg_Listar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Color",
                HeaderText = "Color",
                DisplayIndex = 5
            });
        }

        private void btn_DeBaja_Click(object sender, EventArgs e)
        {
            listaAxuliar = Repositorio_Vehiculos.ListaVehiculos.FindAll(vehiculo => vehiculo.Estado == false);
            dtg_Listar.Columns.Clear();
            OrganizarDataGridVehiculos(listaAxuliar);
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            OrganizarDataGridVehiculos(Repositorio_Vehiculos.ListaVehiculos);
        }

        private void btn_VehiculosActivos_Click(object sender, EventArgs e)
        {
            listaAxuliar = Repositorio_Vehiculos.ListaVehiculos.FindAll(vehiculo => vehiculo.Estado == true);
            dtg_Listar.Columns.Clear();
            OrganizarDataGridVehiculos(listaAxuliar);
        }
    }
}
