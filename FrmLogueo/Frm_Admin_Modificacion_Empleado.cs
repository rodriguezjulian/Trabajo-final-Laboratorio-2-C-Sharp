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
    public partial class Frm_Admin_Modificacion_Empleado : Frm_Empleado_Diseño
    {
        // Repositorio_Empleados repositorio_Empleados = new Repositorio_Empleados();
        //private static List<Empleado> listaEmpleadosAuxiliar = new List<Empleado>();
        public Frm_Admin_Modificacion_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_Admin_Modificacion_Empleado_Load(object sender, EventArgs e)
        {
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados"));
            cbo_Puesto.DataSource = Enum.GetValues(typeof(Puestos));
        }

        private void dtg_ListarEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dtg_ListarEmpleados.CurrentRow.Cells[0].Value.ToString();
            txt_ModNombre.Text = dtg_ListarEmpleados.CurrentRow.Cells[1].Value.ToString();
            cbo_Puesto.Text = dtg_ListarEmpleados.CurrentRow.Cells[2].Value.ToString();
            txt_ModMail.Text = Sistema.ObtenerUsuarioMail(dtg_ListarEmpleados.CurrentRow.Cells[3].Value.ToString());
            cbo_Mail.Text = Sistema.ObtenerTipoMail(dtg_ListarEmpleados.CurrentRow.Cells[3].Value.ToString());

        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Repositorio_Empleados.Repo_Empleados.ModificarEmpleado(txt_ID.Text, txt_ModNombre.Text, txt_ModMail.Text,
                        cbo_Mail.Text, (Puestos)cbo_Puesto.SelectedItem))
                {
                    MessageBox.Show("Datos acuatilizados satisfactoriamente.");
                    dtg_ListarEmpleados.DataSource = null;
                    dtg_ListarEmpleados.Columns.Clear();
                    ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Errores.EscribirLogErrores(ex);
            }

        }

        private void cbo_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados"));
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

        private void btn_Activos_Click(object sender, EventArgs e)
        {
            //listaEmpleadosAuxiliar = Conexion_SQL.Obtener("empleados").FindAll(empleado => empleado.Estado == true);
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == true));
        }

        private void btn_DeBaja_Click(object sender, EventArgs e)
        {
            // listaEmpleadosAuxiliar = Repositorio_Empleados.ListaEmpleado.FindAll(empleado => empleado.Estado == false);
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(Conexion_SQL.ObtenerEmpleados("empleados").FindAll(empleado => empleado.Estado == false));
        }

        private void cbo_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
