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
    public partial class Frm_Cliente_Modificacion_Viaje : Form
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public Frm_Cliente_Modificacion_Viaje()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmModificarViajeCliente_Load(object sender, EventArgs e)
        {
            //PASAR A REPOSITORIO
            viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
            OrganizarDataGridViajes(viajesCliente);
            dtp_FechaDeViaje.MinDate = DateTime.Today;
            lbl_NombreCliente.Text = cliente.Nombre;

        }

        private void pic_EditarViaje_Click(object sender, EventArgs e)
        {
            Viaje? viajeAux;

            // tengo que verificar que el id de viaje sea del cliente y que la fecha se mayor a hoy
            //se supone que por como funciona el cortafuego no deberia ser null viajeAux porque ya se corta el if en la primer condicion
            //El guion bajo (_) se utiliza como una convención para indicar que no se va a utilizar el valor de salida.
            if (txt_IdDeViajeAModificar.Text != "" && Repositorio_Viajes.buscarViaje(int.Parse(txt_IdDeViajeAModificar.Text), out viajeAux) == true
                && viajeAux.NombreCliente == Cliente.Nombre && viajeAux.FechaViaje > DateTime.Today)
            {
                viajeAux.FechaViaje = dtp_FechaDeViaje.Value;
                viajeAux.KilosATransportar = (float)nup_Kg.Value;
                viajesCliente = Repositorio_Viajes.ListaViajes.FindAll(viaje => viaje.NombreCliente == cliente.Nombre);
                OrganizarDataGridViajes(viajesCliente);
                MessageBox.Show("VIAJE MODIFICADO\n" + viajeAux.ToString());
            }
            else
            {
                MessageBox.Show("Verifique datos ingresados. \n");
            }
        }
        #region EVENTOS PARA EL MOUSE
        private void pic_EditarViaje_MouseEnter(object sender, EventArgs e)
        {
            pic_EditarViaje.BackColor = Color.Orange;
        }

        private void pic_EditarViaje_MouseLeave(object sender, EventArgs e)
        {
            pic_EditarViaje.BackColor = Color.Transparent;
        }

        private void pic_CancelarModificacion_MouseEnter(object sender, EventArgs e)
        {
            pic_CancelarModificacion.BackColor = Color.Orange;
        }

        private void pic_CancelarModificacion_MouseLeave(object sender, EventArgs e)
        {
            pic_CancelarModificacion.BackColor = Color.Transparent;
        }
        #endregion
        private void pic_CancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dtg_ListarViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdDeViajeAModificar.Text = dtg_ListaViajes.CurrentRow.Cells[0].Value.ToString();
            dtp_FechaDeViaje.Text = dtg_ListaViajes.CurrentRow.Cells[1].Value.ToString();
            nup_Kg.Text = dtg_ListaViajes.CurrentRow.Cells[3].Value.ToString();
        }
        public void OrganizarDataGridViajes(List<Viaje> viajesCliente)
        {
            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesCliente;


            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdViaje",
                HeaderText = "ID",
                DisplayIndex = 0
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FechaViaje",
                HeaderText = "Fecha",
                DisplayIndex = 1
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "nombreCliente",
                HeaderText = "Nombre",
                DisplayIndex = 2
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "KilosATransportar",
                HeaderText = "KG",
                DisplayIndex = 3
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DireccionSalida",
                HeaderText = "Salida",
                DisplayIndex = 4
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProvinciaDestino",
                HeaderText = "Destino",
                DisplayIndex = 5
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DisplayIndex = 6
            });
        }
    }
}
