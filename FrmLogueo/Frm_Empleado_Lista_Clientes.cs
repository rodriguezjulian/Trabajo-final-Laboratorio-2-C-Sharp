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
    public partial class Frm_Empleado_Lista_Clientes : Form
    {
        private static List<Cliente> listaClientesAuxiliar = new List<Cliente>();
        public Frm_Empleado_Lista_Clientes()
        {
            InitializeComponent();
        }
        private void Frm_Empleado_Listar_Clientes_Load(object sender, EventArgs e)
        {
            ConfigurarDTG(Conexion_SQL.ObtenerClientes("clientes"));
        }
        private void btn_DeBaja_Click(object sender, EventArgs e)
        {
            listaClientesAuxiliar = Conexion_SQL.ObtenerClientes("clientes").FindAll(cliente => cliente.Estado == false);
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(listaClientesAuxiliar);
        }
        private void ConfigurarDTG(List<Cliente> listaClientesAuxiliar)
        {

            dtg_ListarClientes.AutoGenerateColumns = false;
            dtg_ListarClientes.DataSource = listaClientesAuxiliar;
            //#region DATAGRID
            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdCliente",
                HeaderText = "ID",
                DisplayIndex = 0
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                DisplayIndex = 1
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionBSAS",
                HeaderText = "Dirección",
                DisplayIndex = 2
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Rubro",
                HeaderText = "Rubro",
                DisplayIndex = 3
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Correo Electrónico",
                DisplayIndex = 4
            });
            //#endregion
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Activos_Click(object sender, EventArgs e)
        {
            listaClientesAuxiliar = Conexion_SQL.ObtenerClientes("clientes").FindAll(cliente => cliente.Estado == true);
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(listaClientesAuxiliar);
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerClientes("clientes"));
        }
    }
}
