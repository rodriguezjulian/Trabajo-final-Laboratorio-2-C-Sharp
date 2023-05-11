using FrmLogueo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_TransporteRodriguez
{
    public partial class Frm_Empleado_Alta_Cliente : Form
    {
        Usuario empleadoInstanciado;
        Cliente nuevoCliente;
        public Frm_Empleado_Alta_Cliente()
        {
            InitializeComponent();
        }

        public Usuario EmpleadoInstanciado { get => empleadoInstanciado; set => empleadoInstanciado = value; }
        public Cliente NuevoCliente { get => nuevoCliente; set => nuevoCliente = value; }



        //COMO ES UN FORMULARIO QUE SE MUESTRA COMO MODAL PUEDO HACER ESTO
        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            /*
             *         public Cliente(string nombre, string contraseña, string mail,short idCliente, string? direccionBSAS, string? rubro) 
            : base(nombre, contraseña, mail)
             */
            NuevoCliente = new Cliente(txt_AltaNombre.Text, txt_AltaContraseña.Text, txt_AltaMail.Text, short.Parse(txt_AltaId.Text),
               txt_AltaDireccion.Text, cbo_Rubro.SelectedValue.ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cbo_Rubro.SelectedIndex = 2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }

    }
}
