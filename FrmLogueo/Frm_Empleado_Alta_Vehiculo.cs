using Enumerado;
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
    public partial class Frm_Empleado_Alta_Vehiculo : Frm_Empleado_Diseño
    {
        // Repositorio_Vehiculos repositorio_Vehiculos=new Repositorio_Vehiculos();
        public Frm_Empleado_Alta_Vehiculo()
        {
            InitializeComponent();
        }
        private void Frm_Empleado_Alta_Vehiculo_Load(object sender, EventArgs e)
        {
            cbo_Marca.DataSource = Enum.GetValues(typeof(Marcas));
            cbo_Color.DataSource = Enum.GetValues(typeof(Colores));
        }

        private void pic_Guardar_Click(object sender, EventArgs e)
        {
            /*Repositorio_Vehiculos.ListaVehiculos.Add(new Vehiculo(Repositorio_Vehiculos.Repo_Vehiculos.CalcularId(), (Marcas)cbo_Marca.SelectedItem,
                (int)nup_Kilos.Value, (Colores)cbo_Color.SelectedItem, txt_AltaPatente.Text, true));*/
            try
            {
                Repositorio_Vehiculos.Repo_Vehiculos.CrearVehiculo((Marcas)cbo_Marca.SelectedItem, nup_Kilos.Value.ToString(), (Colores)cbo_Color.SelectedItem, txt_AltaPatente.Text);
                MessageBox.Show("Vehiculo creado satisfactoriamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
