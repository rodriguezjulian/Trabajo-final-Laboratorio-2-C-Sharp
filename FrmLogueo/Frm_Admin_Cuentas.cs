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
    public partial class Frm_Admin_Cuentas : Form
    {  
        public Frm_Admin_Cuentas()
        {
            InitializeComponent();
        }
        private void RecibirExcepcion(string excepcion)
        {
            label1.Text = excepcion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Frm_Admin_Cuentas_Load(object sender, EventArgs e)
        {
            Frm_Cliente_Alta_Viaje formDelProblema = new Frm_Cliente_Alta_Viaje();
            //formDelProblema.eventFecha += RecibirExcepcion;
        }
    }
}
