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
    public partial class Frm_Cliente_Lista_Viajes : Form, I_Grafica
    {
        Cliente cliente;
        List<Viaje> viajesCliente;
        public Frm_Cliente_Lista_Viajes()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }

        private void FrmListarViajesCliente_Load(object sender, EventArgs e)
        {
            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.Estado == true);
            lbl_NombreCliente.Text = cliente.Nombre;
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
            btn_Cancelados.Click += CambiarFondoDeBotones;
            btn_ViajesPendientes.Click += CambiarFondoDeBotones;
            btn_ViajesRealizados.Click += CambiarFondoDeBotones;
            btn_ViajesTodos.Click += CambiarFondoDeBotones;
            btn_ViajesTodos.BackColor = System.Drawing.Color.Gray;
        }

        private void pic_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_ViajesRealizados_Click(object sender, EventArgs e)
        {
            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.FechaViaje < DateTime.Now && viaje.Estado == true);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }
        private void btn_ViajesTodos_Click(object sender, EventArgs e)
        {
            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.Estado == true);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }
        private void btn_ViajesPendientes_Click(object sender, EventArgs e)
        {
            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.FechaViaje > DateTime.Now && viaje.Estado == true);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }
        public void OrganizarDataGridViajes(List<Viaje> viajesCliente)
        {

            dtg_ListaViajes.AutoGenerateColumns = false;
            dtg_ListaViajes.DataSource = viajesCliente;

            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdViaje",
                HeaderText = "ID VIAJE",
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
                DataPropertyName = "DireccionSalida",
                HeaderText = "Salida",
                DisplayIndex = 3
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ProvinciaDestino",
                HeaderText = "Destino",
                DisplayIndex = 4
            });
            dtg_ListaViajes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                DisplayIndex = 5
            });
        }

        private void btn_Cancelados_Click(object sender, EventArgs e)
        {
            viajesCliente = Conexion_SQL.ObtenerViajes("viajes").FindAll(viaje => viaje.IdCliente == cliente.IdCliente && viaje.Estado == false);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(viajesCliente);
        }

        public void CambiarFondoDeBotones(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = (Button)sender;
                switch (boton.Name)
                {
                    case "btn_ViajesRealizados":
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.Gray;
                        btn_Cancelados.BackColor = System.Drawing.Color.Red;
                        btn_ViajesPendientes.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                        btn_ViajesTodos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        break;
                    case "btn_Cancelados":
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        btn_Cancelados.BackColor = System.Drawing.Color.Gray;
                        btn_ViajesPendientes.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                        btn_ViajesTodos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        break;
                    case "btn_ViajesPendientes":
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        btn_Cancelados.BackColor = System.Drawing.Color.Red;
                        btn_ViajesPendientes.BackColor = System.Drawing.Color.Gray;
                        btn_ViajesTodos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        break;
                    case "btn_ViajesTodos":
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        btn_Cancelados.BackColor = System.Drawing.Color.Red;
                        btn_ViajesPendientes.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                        btn_ViajesTodos.BackColor = System.Drawing.Color.Gray;
                        break;
                }
            }
        }
    }
}
