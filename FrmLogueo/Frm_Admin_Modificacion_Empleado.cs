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
        private static List<Empleado> listaEmpleadosAuxiliar = new List<Empleado>();
        public Frm_Admin_Modificacion_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_Admin_Modificacion_Empleado_Load(object sender, EventArgs e)
        {
            ConfigurarDTG(Repositorio_Empleados.ListaEmpleado);
            cbo_Puesto.DataSource = Enum.GetValues(typeof(Puestos));
        }

        private void dtg_ListarEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dtg_ListarEmpleados.CurrentRow.Cells[0].Value.ToString();
            txt_ModNombre.Text = dtg_ListarEmpleados.CurrentRow.Cells[1].Value.ToString();
            cbo_Puesto.Text = dtg_ListarEmpleados.CurrentRow.Cells[2].Value.ToString();
            txt_ModMail.Text = dtg_ListarEmpleados.CurrentRow.Cells[3].Value.ToString();
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                Empleado empleado = Repositorio_Empleados.Repo_Empleados.BuscarInstanciaId(int.Parse(txt_ID.Text));
                empleado.Nombre = txt_ModNombre.Text;
                empleado.Puesto = (Puestos)cbo_Puesto.SelectedItem;
                empleado.Mail = txt_ModMail.Text;

                dtg_ListarEmpleados.DataSource = null;
                dtg_ListarEmpleados.Rows.Clear();
                dtg_ListarEmpleados.AutoGenerateColumns = false;
                dtg_ListarEmpleados.DataSource = Repositorio_Empleados.ListaEmpleado;
            }
            else
            {
                MessageBox.Show("ERROR, Seleccione empleado a modificar");
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
            ConfigurarDTG(Repositorio_Empleados.ListaEmpleado);
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
            listaEmpleadosAuxiliar = Repositorio_Empleados.ListaEmpleado.FindAll(empleado => empleado.Estado == true);
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(listaEmpleadosAuxiliar);
        }

        private void btn_DeBaja_Click(object sender, EventArgs e)
        {
            listaEmpleadosAuxiliar = Repositorio_Empleados.ListaEmpleado.FindAll(empleado => empleado.Estado == false);
            dtg_ListarEmpleados.Columns.Clear();
            ConfigurarDTG(listaEmpleadosAuxiliar);
        }
    }
}
