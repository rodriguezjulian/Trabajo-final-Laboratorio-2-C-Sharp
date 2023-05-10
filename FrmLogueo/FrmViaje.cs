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
    public partial class FrmViaje : Form
    {
        Usuario clienteInstanciado;
        Cliente cliente;
        public FrmViaje()
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
        }

        private void pic_ReservarViajar_Click(object sender, EventArgs e)
        {
            if (txt_Kg.Text != "")
            {
                if (Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), dtp_FechaDeViaje.Value) != 0)
                {
                    Sistema.ListaViajes.Add(new Viaje(Sistema.CalcularIdViaje(), txt_Nombre.Text, txt_DireccionSalida.Text,
                    cbo_Provincias.SelectedItem.ToString(), float.Parse(txt_Kg.Text),
                    Sistema.calcularPrecioViaje(cbo_Provincias.SelectedIndex, float.Parse(txt_Kg.Text)),
                    Sistema.RetornarVehiculoDisponible(float.Parse(txt_Kg.Text), dtp_FechaDeViaje.Value),
                     dtp_FechaDeViaje.Value));
                    MessageBox.Show("Viaje reservado satisfactoriamente.\n");
                    FrmMenuCliente anterior = new FrmMenuCliente();
                    anterior.usuarioInstanciado = clienteInstanciado;
                    this.Close();
                    anterior.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR, No hay vehiculo disponible en esa fecha y con esa capacidad de carga\n");
                }
            }
            else
            {
                MessageBox.Show("ERROR, Recuerde completar todos los campos \n");
            }

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
