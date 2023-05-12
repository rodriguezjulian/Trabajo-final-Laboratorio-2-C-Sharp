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
        private static List<Cliente> listaClientesBaja = new List<Cliente>();
        public Frm_Empleado_Listar_Clientes()
        {
            InitializeComponent();
        }
        private void Frm_Empleado_Listar_Clientes_Load(object sender, EventArgs e)
        {
            dtg_ListarClientes.DataSource = Sistema.ListaClientes;
            dtg_ListarClientes.AutoGenerateColumns = false;
            ConfigurarDTG();
        }
        private void btn_DeBaja_Click(object sender, EventArgs e)
        {

            if (Sistema.FiltrarClientes(listaClientesBaja))
            {
                dtg_ListarClientes.DataSource = null;
                dtg_ListarClientes.Rows.Clear();
                dtg_ListarClientes.AutoGenerateColumns = false;
                dtg_ListarClientes.DataSource = listaClientesBaja;
                ConfigurarDTG();
            }
            else
            {
                MessageBox.Show("No existen clientes dados de baja.\n");
            }
        }
        private void ConfigurarDTG()
        {

            #region DATAGRID


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
            #endregion
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }
    }
}
