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



        //COMO ES UN FORMULARIO QUE SE MUESTRA COMO MODAL PUEDO HACER ESTO
        private void btn_GuardarCliente_Click(object sender, EventArgs e)
        {
            /*
             *         public Cliente(string nombre, string contraseña, string mail,short idCliente, string? direccionBSAS, string? rubro) 
            : base(nombre, contraseña, mail)
             */
            nuevoCliente = new Cliente(txt_AltaNombre.Text, txt_AltaContraseña.Text, txt_AltaMail.Text, short.Parse(txt_AltaId.Text),
               txt_AltaDireccion.Text, cbo_Rubro.SelectedValue.ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cbo_Rubro.SelectedIndex = 2;
            lbl_nombreUsuario.Text = empleadoInstanciado.Nombre;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
                         //   Form anterior = new Frm_Login(); // Crea una instancia del formulario anterior
                         // anterior.ShowDialog(); // Muestra el formulario anterior como diálogo
            this.Close(); // Cierra el formulario actual
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
