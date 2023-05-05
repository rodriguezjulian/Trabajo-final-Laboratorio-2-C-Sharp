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
    public partial class FrmMenuEmpleado : Form
    {
        List<Cliente> listaEmpleados;
        public FrmMenuEmpleado()
        {
            InitializeComponent();
            listaEmpleados = new List<Cliente>();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSTACIO EL FORMULARIO SIGUIENTE
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
            //DialogResult confirmacion
            if (frmAltaCliente.ShowDialog() == DialogResult.OK) //cuando mostramos con ShowDialog damos foco a ese formulario
            {

            }


        }

    }
}
