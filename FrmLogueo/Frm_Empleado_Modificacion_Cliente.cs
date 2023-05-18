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
        //Repositorio_Clientes repositorio_Clientes = new Repositorio_Clientes();
        public Frm_Empleado_Modificacion_Cliente()
        {
            InitializeComponent();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
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
            txt_ModMail.Text = Sistema.ObtenerUsuarioMail(dtg_ListarClientes.CurrentRow.Cells[4].Value.ToString());
            cbo_Mail.Text = Sistema.ObtenerTipoMail(dtg_ListarClientes.CurrentRow.Cells[4].Value.ToString());
        }
        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            if (!string.IsNullOrEmpty(txt_ID.Text))
            {
                if (Repositorio_Clientes.Repo_Clientes.ModificarCliente(int.Parse(txt_ID.Text), txt_ModNombre.Text,
                txt_ModMail.Text, cbo_Mail.Text, txt_ModDireccion.Text, cbo_Rubro.Text, out cliente))
                {
                    MessageBox.Show("DATOS DEL CLIENTE " + cliente.ToString());
                    dtg_ListarClientes.DataSource = null;
                    dtg_ListarClientes.Rows.Clear();
                    dtg_ListarClientes.AutoGenerateColumns = false;
                    dtg_ListarClientes.DataSource = Repositorio_Clientes.ListaClientes;
                }
                else
                {
                    MessageBox.Show("ERROR, Revise datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("ERROR, Seleccione cliente a modificar");
            }
        }

        private void cbo_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbo_Rubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
