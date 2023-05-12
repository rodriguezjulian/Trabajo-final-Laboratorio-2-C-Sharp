using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Lista_Viajes : Form
    {
        public Frm_Empleado_Lista_Viajes()
        {
            InitializeComponent();
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
