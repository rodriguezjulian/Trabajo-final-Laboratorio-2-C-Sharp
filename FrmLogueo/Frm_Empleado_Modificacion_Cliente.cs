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
    public partial class Frm_Empleado_Modificacion_Cliente : Frm_Empleado_Diseño
    {
        public Frm_Empleado_Modificacion_Cliente()
        {
            InitializeComponent();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }

        private void Frm_Empleado_Modificacion_Cliente_Load(object sender, EventArgs e)
        {
            dtg_ListarClientes.AutoGenerateColumns = false;
            #region DATAGRID

            dtg_ListarClientes.DataSource = Repositorio_Clientes.ListaClientes;
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
                HeaderText = "Mail",
                DisplayIndex = 4
            });

            dtg_ListarClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                DisplayIndex = 5
            });
            #endregion
        }

        private void dtg_ListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dtg_ListarClientes.CurrentRow.Cells[0].Value.ToString();
            txt_ModNombre.Text = dtg_ListarClientes.CurrentRow.Cells[1].Value.ToString();
            txt_ModDireccion.Text = dtg_ListarClientes.CurrentRow.Cells[2].Value.ToString();
            cbo_Rubro.Text = dtg_ListarClientes.CurrentRow.Cells[3].Value.ToString();
            txt_ModMail.Text = dtg_ListarClientes.CurrentRow.Cells[4].Value.ToString();
        }
        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                Cliente cliente = Repositorio_Clientes.BuscarCliente(int.Parse(txt_ID.Text));
                cliente.Nombre = txt_ModNombre.Text;
                cliente.Rubro = cbo_Rubro.Text;
                cliente.Mail = txt_ModMail.Text;
                cliente.DireccionBSAS = txt_ModDireccion.Text;
                MessageBox.Show("DATOS DEL CLIENTE "+ cliente.ToString());
                dtg_ListarClientes.DataSource = null;
                dtg_ListarClientes.Rows.Clear();
                dtg_ListarClientes.AutoGenerateColumns = false;
                dtg_ListarClientes.DataSource = Repositorio_Clientes.ListaClientes;
            }
            else
            {
                MessageBox.Show("ERROR, Seleccione cliente a modificar");
            }
        }
    }
}
