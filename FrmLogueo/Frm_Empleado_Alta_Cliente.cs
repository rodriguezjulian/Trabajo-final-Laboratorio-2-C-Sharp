using FrmLogueo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        //Repositorio_Clientes repositorio_Clientes = new Repositorio_Clientes();


        public Frm_Empleado_Alta_Cliente()
        {
            InitializeComponent();
        }

        public Usuario EmpleadoInstanciado { get => empleadoInstanciado; set => empleadoInstanciado = value; }
        public Cliente NuevoCliente { get => nuevoCliente; set => nuevoCliente = value; }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cbo_Rubro.SelectedIndex = 2;
            cbo_Mail.SelectedIndex = 1;
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            // Frm_Empleado_Menu.actualizarPanel(Frm_Empleado_Menu.pnl_Padre, Frm_Empleado_Menu.hora);
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GuardarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                Repositorio_Clientes.Repo_Clientes.CrearCliente(txt_AltaNombre.Text, txt_AltaMail.Text, cbo_Mail.SelectedItem.ToString(),
                    txt_AltaDireccion.Text, cbo_Rubro.SelectedItem.ToString());
                MessageBox.Show("Cliente creado satisfactoriamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
