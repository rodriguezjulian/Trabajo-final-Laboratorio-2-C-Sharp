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
    public partial class Frm_Admin_Lista_Empleado : Form
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
            ConfigurarDTG(listaEmpleadosAuxiliar= Conexion_SQL.ObtenerEmpleado("empleados"));
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(listaEmpleadosAuxiliar = Conexion_SQL.ObtenerEmpleado("empleados"));
        }

        private void btn_Activos_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            listaEmpleadosAuxiliar = Conexion_SQL.ObtenerEmpleado("empleados").FindAll(empleado => empleado.Estado == true);
            
            ConfigurarDTG(listaEmpleadosAuxiliar);
        }

        private void btn_DeBaja_Click(object sender, EventArgs e)
        {   
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleado("empleados").FindAll(empleado => empleado.Estado == false));
        }
        private void ConfigurarDTG(List<Empleado> ListaEmpleado)
        {
            #region DATA GRID 
            dtg_ListarEmpleados.AutoGenerateColumns = false;
            dtg_ListarEmpleados.DataSource =ListaEmpleado;

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
    }
}
