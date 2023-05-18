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
    public partial class Frm_Admin_Alta_Empleado : Frm_Empleado_Diseño
    {
        public Frm_Admin_Alta_Empleado()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cbo_Puesto.DataSource = Enum.GetValues(typeof(Puestos));
            cbo_Mail.SelectedIndex = 1;
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            if (Repositorio_Empleados.Repo_Empleados.CrearEmpleado(txt_AltaNombre.Text, txt_AltaMail.Text, cbo_Mail.SelectedItem.ToString(), (Puestos)cbo_Puesto.SelectedItem))
            {
                MessageBox.Show("Empleado dado de alta satisfactoriamente\n");
            }
            else
            {
                MessageBox.Show("ERROR, Verifique los datos ingresados\n");
            }
        }
    }
}
