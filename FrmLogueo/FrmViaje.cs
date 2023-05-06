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
        public FrmViaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listaVehiculos.Add(new Vehiculo(3, Marcas.Ford, 2000, Colores.Negro, "GHI789"));
            Sistema.ListaViajes.Add(new Viaje(short.Parse(txt_Id.Text), txt_Nombre.Text, txt_DireccionSalida.Text,
                txt_ProvinciaDestino.Text, float.Parse(txt_Precio.Text), short.Parse(txt_IdVehiculo.Text), DateTime.Parse(txt_Fecha.Text)));
        }
    }
}
