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
    public partial class Frm_Cliente_Datos : Form
    {
        Cliente cliente;
        public Frm_Cliente_Datos()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmDatosCliente_Load(object sender, EventArgs e)
        {
            lbl_NombreCliente.Text = cliente.Nombre;
            txt_Id.Text = cliente.IdCliente.ToString();
            txt_NombreCliente.Text = cliente.Nombre;
            txt_Direccion.Text = cliente.DireccionBSAS;
            txt_Mail.Text = cliente.Mail;
            txt_Rubro.Text = cliente.Rubro;
        }
    }
}
