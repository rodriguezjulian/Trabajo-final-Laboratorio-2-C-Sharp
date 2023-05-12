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
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cbo_Rubro.SelectedIndex = 2;
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }

        private void btn_GuardarCliente_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(cbo_Rubro.SelectedItem.ToString());
            if (txt_AltaNombre.Text != "" && txt_AltaMail.Text != "" && txt_AltaDireccion.Text != "")
            {
                Sistema.ListaClientes.Add(new Cliente(txt_AltaNombre.Text, Sistema.generarContraseña(), txt_AltaMail.Text, true,
                 Sistema.CalcularIdCliente(), txt_AltaDireccion.Text, cbo_Rubro.SelectedItem.ToString()));

                MessageBox.Show("Cliente dado de alta satisfactoriamente\n");
            }
            else
            {
                MessageBox.Show("ERROR, Verifique los datos ingresados\n");
            }
        }
    }
}
