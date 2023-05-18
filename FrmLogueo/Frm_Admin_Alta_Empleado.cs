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
       // Repositorio_Empleados repositorio_Empleados=new Repositorio_Empleados ();
        public Frm_Admin_Alta_Empleado()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //cbo_Puesto.SelectedIndex = 2;
            cbo_Puesto.DataSource = Enum.GetValues(typeof(Puestos));
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_AltaNombre.Text != "" && txt_AltaMail.Text != "")
            {
                Repositorio_Empleados.ListaEmpleado.Add(new Empleado(txt_AltaNombre.Text,
                    Sistema.generarContraseña(), txt_AltaMail.Text, true, Repositorio_Empleados.Repo_Empleados.CalcularId(), (Puestos)cbo_Puesto.SelectedItem));

                MessageBox.Show("Empleado dado de alta satisfactoriamente\n");
            }
            else
            {
                MessageBox.Show("ERROR, Verifique los datos ingresados\n");
            }
        }
    }
}
