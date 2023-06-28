using Google.Type;
using MySqlX.XDevAPI;
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
using static TransporteRodriguez.Repositorio_Clientes;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Lista_Clientes : Form
    {
        private static List<Cliente> listaClientesAuxiliar;
        ClienteData clienteFiltrar = null;
        public Frm_Empleado_Lista_Clientes()
        {
            InitializeComponent();
        }
        private void Frm_Empleado_Listar_Clientes_Load(object sender, EventArgs e)
        {
            ConfigurarDTG(Conexion_SQL.ObtenerClientes("clientes"));
            btn_DeBaja.Click += CambiarCheck;
            btn_Activos.Click += CambiarCheck;
            btn_Todos.Click += CambiarCheck;

            btn_Todos.Click += CambiarFondo;
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

          /*  clienteFiltrar = Repo_Clientes.FiltrarClienteActivo;
           // listaClientesAuxiliar = Conexion_SQL.ObtenerClientes("clientes");
            foreach(Cliente cliente in Conexion_SQL.ObtenerClientes("clientes"))
            {
                if (clienteFiltrar(cliente))
                {
                    listaClientesAuxiliar.Add(cliente);
                }
            }*/
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(listaClientesAuxiliar);
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {

            // this.btn_Todos.Click += CambiarFondo;


            // this.btn_Todos.BackColor = Color.Gray;
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerClientes("clientes"));
            //this.btn_Todos.Click -= CambiarCheck;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.check;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            listaClientesAuxiliar = Conexion_SQL.ObtenerClientes("clientes");
            listaClientesAuxiliar.Sort((Cliente cliente, Cliente cliente2) => cliente.Nombre.CompareTo(cliente2.Nombre));
            dtg_ListarClientes.Columns.Clear();
            ConfigurarDTG(listaClientesAuxiliar);
        }
        private void CambiarCheck(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void CambiarFondo(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = (Button)sender;
                if (boton.Name == "btn_Todos")
                {
                    btn_Todos.BackColor = System.Drawing.Color.Gray;
                    btn_Activos.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn_DeBaja.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                }
            }
            /*btn_Todos.BackColor = Color.FromArgb(192, 255, 255);
            btn_Activos.BackColor = Color.FromArgb(192, 255, 192);
            btn_DeBaja.BackColor = Color.FromArgb(255, 192, 192);*/
        }

    }
}
