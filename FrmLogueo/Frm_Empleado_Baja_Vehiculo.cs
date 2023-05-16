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
    public partial class Frm_Empleado_Baja_Vehiculo : Frm_Empleado_Diseño
    {
        public Frm_Empleado_Baja_Vehiculo()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Baja_Vehiculo_Load(object sender, EventArgs e)
        {
            OrganizarDataGridVehiculos(Repositorio_Vehiculos.ListaVehiculos);
        }
        public void OrganizarDataGridVehiculos(List<Vehiculo> ListaVehiculos)
        {
            dtg_Listar.AutoGenerateColumns = false;
            dtg_Listar.DataSource = Repositorio_Vehiculos.ListaVehiculos;

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
    }
}
