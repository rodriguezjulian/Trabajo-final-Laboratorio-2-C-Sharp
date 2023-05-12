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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Listar_Clientes : Form
    {
        public Frm_Empleado_Listar_Clientes()
        {
            InitializeComponent();
            dtg_ListarClientes.AutoGenerateColumns = false;
            dtg_ListarClientes.DataSource = Sistema.ListaClientes;

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                DisplayIndex = 0
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionBSAS",
                HeaderText = "Dirección",
                DisplayIndex = 1
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Rubro",
                HeaderText = "Rubro",
                DisplayIndex = 2
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Correo Electrónico",
                DisplayIndex = 3
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                DisplayIndex = 4
            });
        }
    }
}
