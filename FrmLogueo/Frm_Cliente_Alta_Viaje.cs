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
    public partial class Frm_Cliente_Alta_Viaje : Form
    {
        Usuario clienteInstanciado;
        Cliente cliente;
        public Frm_Cliente_Alta_Viaje()
        {
            InitializeComponent();
        }

        public Usuario ClienteInstanciado { get => clienteInstanciado; set => clienteInstanciado = value; }
        private void FrmViaje_Load(object sender, EventArgs e)
        {
            cliente = Sistema.BuscarCliente(clienteInstanciado);
            txt_Nombre.Text = cliente.Nombre;
            txt_DireccionSalida.Text = cliente.DireccionBSAS;
            cbo_Provincias.SelectedIndex = 0;
            dtp_FechaDeViaje.MinDate = DateTime.Today;
            lbl_NombreClient.Text = cliente.Nombre;
        }

        private void pic_ReservarViajar_Click(object sender, EventArgs e)
        {
            if (Sistema.RetornarVehiculoDisponible((float)nup_Kilos.Value, dtp_FechaDeViaje.Value) != 0)
            {
                Sistema.ListaViajes.Add(new Viaje(Sistema.CalcularIdViaje(), txt_Nombre.Text, txt_DireccionSalida.Text,
                cbo_Provincias.SelectedItem.ToString(), (float)nup_Kilos.Value,
                Sistema.calcularPrecioViaje(cbo_Provincias.SelectedIndex, (float)nup_Kilos.Value),
                Sistema.RetornarVehiculoDisponible((float)nup_Kilos.Value, dtp_FechaDeViaje.Value),
                    dtp_FechaDeViaje.Value));
                MessageBox.Show("Viaje reservado satisfactoriamente.\n");
                Frm_Cliente_Menu anterior = new Frm_Cliente_Menu();
                anterior.usuarioInstanciado = clienteInstanciado;
                this.Close();
                anterior.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
            }
        }

        private void pic_ReservarViajar_MouseLeave(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Transparent;
        }

        private void pic_ReservarViajar_MouseEnter(object sender, EventArgs e)
        {
            pic_ReservarViajar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Orange;
        }

        private void pic_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            pic_Cancelar.BackColor = Color.Transparent;
        }

        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Close();
        }


        /*
        private void pictureBox1_Click(object sender, EventArgs e)
{
   MessageBox.Show(dtp_FechaDeViaje.Value.ToString());
   if (Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), dtp_FechaDeViaje.Value) != 0)
   {
       Sistema.ListaViajes.Add(new Viaje(Sistema.CalcularIdViaje(), txt_Nombre.Text, txt_DireccionSalida.Text,
       cbo_Provincias.SelectedItem.ToString(), float.Parse(txt_Kg.Text),
       Sistema.calcularPrecioViaje(cbo_Provincias.SelectedIndex, float.Parse(txt_Kg.Text)),
       Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), dtp_FechaDeViaje.Value),
        dtp_FechaDeViaje.Value));
   }
   else
   {
       MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
   }
}
*/
    }
}
