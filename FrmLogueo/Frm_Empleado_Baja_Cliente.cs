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
    public partial class Frm_Empleado_Baja_Cliente : Frm_Empleado_Diseño
    {
        List<Viaje> clientesActivos;
        public Frm_Empleado_Baja_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Baja_Cliente_Load(object sender, EventArgs e)
        {
            List<Cliente> clientesActivos = Repositorio_Clientes.ListaClientes.FindAll(cliente => cliente.Estado == true);
            OrganizarDtg(clientesActivos);
        }

        private void dtg_ListarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_BajaID.Text = dtg_ListarClientes.CurrentRow.Cells[0].Value.ToString();
            txt_BajaNombre.Text = dtg_ListarClientes.CurrentRow.Cells[1].Value.ToString();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            // Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {

            if (txt_BajaID.Text != "")
            {
                Cliente cliente = Repositorio_Clientes.BuscarCliente(int.Parse(txt_BajaID.Text));
                if (cliente.Estado == true)
                {
                    cliente.Estado = false;
                    MessageBox.Show("BAJA CONFIRMADA\n" + cliente.ToString());
                    dtg_ListarClientes.DataSource = null;
                    dtg_ListarClientes.Rows.Clear();
                    dtg_ListarClientes.AutoGenerateColumns = false;
                    dtg_ListarClientes.DataSource = Repositorio_Clientes.ListaClientes;
                    dtg_ListarClientes.Columns.Clear();

                    List<Cliente> clientesActivos = Repositorio_Clientes.ListaClientes.FindAll(cliente => cliente.Estado == true);
                    OrganizarDtg(clientesActivos);

                }
            }
            else
            {
                MessageBox.Show("ERROR, Seleccione cliente a dar de baja");
            }
        }
        private void OrganizarDtg(List<Cliente> clientesActivos)
        {

            dtg_ListarClientes.AutoGenerateColumns = false;


            dtg_ListarClientes.DataSource = clientesActivos;
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
        }
    }
}
