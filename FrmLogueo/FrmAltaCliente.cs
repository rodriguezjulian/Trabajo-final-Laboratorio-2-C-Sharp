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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        //COMO ES UN FORMULARIO QUE SE MUESTRA COMO MODAL PUEDO HACER ESTO
        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente(txt_AltaNombre.Text,txt_AltaContraseña.Text,
                txt_AltaDireccion.Text, txt_AltaRubro.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_SalirAltaCliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
