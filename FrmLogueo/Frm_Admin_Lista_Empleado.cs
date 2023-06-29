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
    public partial class Frm_Admin_Lista_Empleado : Form,I_Grafica
    {
        private static List<Empleado> listaEmpleadosAuxiliar = new List<Empleado>();
        public Frm_Admin_Lista_Empleado()
        {
            InitializeComponent();
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_Admin_Lista_Empleado_Load(object sender, EventArgs e)
        {
            ConfigurarDTG(listaEmpleadosAuxiliar = Conexion_SQL.ObtenerEmpleados("empleados"));
            btn_Todos.Click += CambiarFondoDeBotones;
            btn_Activos.Click += CambiarFondoDeBotones;
            btn_DeBaja.Click += CambiarFondoDeBotones;
            btn_Todos.BackColor = System.Drawing.Color.Gray;
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(listaEmpleadosAuxiliar = Conexion_SQL.ObtenerEmpleados("empleados"));
        }

        private void btn_Activos_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            listaEmpleadosAuxiliar = Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == true);

            ConfigurarDTG(listaEmpleadosAuxiliar);
        }

        private void btn_DeBaja_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == false));
        }
        private void ConfigurarDTG(List<Empleado> ListaEmpleado)
        {
            #region DATA GRID 
            dtg_ListarEmpleados.AutoGenerateColumns = false;
            dtg_ListarEmpleados.DataSource = ListaEmpleado;

            dtg_ListarEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdEmpleado",
                HeaderText = "ID",
                DisplayIndex = 0
            });
            dtg_ListarEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                DisplayIndex = 1
            });

            dtg_ListarEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Puesto",
                HeaderText = "Puesto",
                DisplayIndex = 2
            });
            dtg_ListarEmpleados.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mail",
                HeaderText = "Mail",
                DisplayIndex = 3
            });
            #endregion
        }
        public void CambiarFondoDeBotones(object sender, EventArgs e)
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
                else
                {
                    if (boton.Name == "btn_Activos")
                    {
                        btn_Todos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        btn_Activos.BackColor = System.Drawing.Color.Gray;
                        btn_DeBaja.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        btn_Todos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        btn_Activos.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        btn_DeBaja.BackColor = System.Drawing.Color.Gray;
                    }
                }
            }
        }
        }
}
