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
    public partial class Frm_Hora : Form
    {
        public Frm_Hora()
        {
            InitializeComponent();
        }

        private void tmr_HoraMenu_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToString("dddd MMM yyy");
        }
    }
}
