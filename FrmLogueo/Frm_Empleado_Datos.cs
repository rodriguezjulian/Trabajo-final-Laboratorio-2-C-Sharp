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
    public partial class Frm_Empleado_Datos : Form
    {
        Empleado empleado;
        public Frm_Empleado_Datos()
        {
            InitializeComponent();
        }

        public Empleado Empleado { get => empleado; set => empleado = value; }

        private void Frm_Empleado_Datos_Load(object sender, EventArgs e)
        {
            txt_Id.Text = empleado.IdEmpleado.ToString();
            txt_Mail.Text = empleado.Mail.ToString();
            txt_NombreCliente.Text = empleado.Nombre.ToString();
            txt_Cargo.Text = empleado.Puesto.ToString();
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
