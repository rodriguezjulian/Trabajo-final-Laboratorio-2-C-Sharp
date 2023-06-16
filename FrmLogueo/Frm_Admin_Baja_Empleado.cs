using Enumerado;
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
    public partial class Frm_Admin_Baja_Empleado : Frm_Empleado_Diseño
    {
        List<Empleado> empleadosActivos;
        Empleado empleado;

        public Empleado Empleado { get => empleado; set => empleado = value; }

        public Frm_Admin_Baja_Empleado()
        {
            InitializeComponent();
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_Admin_Baja_Empleado_Load(object sender, EventArgs e)
        {
            empleadosActivos = Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == true);
            #region DATA GRID 
            dtg_ListarEmpleados.AutoGenerateColumns = false;
            dtg_ListarEmpleados.DataSource = empleadosActivos;

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

        private void dtg_ListarEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_BajaID.Text = dtg_ListarEmpleados.CurrentRow.Cells[0].Value.ToString();
            txt_BajaNombre.Text = dtg_ListarEmpleados.CurrentRow.Cells[1].Value.ToString();
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = Repositorio_Empleados.Repo_Empleados.DarDeBaja(txt_BajaID.Text, Empleado);

                dtg_ListarEmpleados.DataSource = null;
                dtg_ListarEmpleados.Rows.Clear();
                dtg_ListarEmpleados.AutoGenerateColumns = false;
                empleadosActivos = Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == true);
                dtg_ListarEmpleados.DataSource = empleadosActivos;
                MessageBox.Show("Baja satisfactoria");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
