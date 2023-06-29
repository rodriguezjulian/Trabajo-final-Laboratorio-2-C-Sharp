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
    public partial class Frm_Empleado_Lista_Viajes : Form, I_Grafica //CambiarFondoDeBotones
    {
        List<Viaje> listaAuxiliar;

        Predicate<Viaje> FiltrarDelegateEstado;
        Predicate<Viaje> FiltrarDelegateFecha;


        public Frm_Empleado_Lista_Viajes()
        {
            InitializeComponent();
        }

        private void pic_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Frm_Empleado_Lista_Viajes_Load(object sender, EventArgs e)
        {
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes");
            OrganizarDataGridViajes(listaAuxiliar);
            btn_Todos.BackColor = System.Drawing.Color.Gray;
            btn_Todos.Click += CambiarFondoDeBotones;
            btn_ViajesCancelados.Click += CambiarFondoDeBotones;
            btn_ViajesRealizados.Click += CambiarFondoDeBotones;
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

        private void btn_ViajesRealizados_Click(object sender, EventArgs e)
        {
            FiltrarDelegateFecha = Repositorio_Viajes.Repo_Viajes.FiltrarViajeRealizado;
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(FiltrarDelegateFecha);
            dtg_ListaViajes.Columns.Clear();
            OrganizarDataGridViajes(listaAuxiliar);
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dtg_ListaViajes.Columns.Clear();
            FiltrarDelegateEstado = Repositorio_Viajes.Repo_Viajes.FiltrarViajeActivo;
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(FiltrarDelegateEstado);
            OrganizarDataGridViajes(listaAuxiliar);
        }

        private void btn_ViajesCancelados_Click(object sender, EventArgs e)
        {
            dtg_ListaViajes.Columns.Clear();
            FiltrarDelegateEstado = Repositorio_Viajes.Repo_Viajes.FiltrarViajeInactivo;
            listaAuxiliar = Conexion_SQL.ObtenerViajes("viajes").FindAll(FiltrarDelegateEstado);
            OrganizarDataGridViajes(listaAuxiliar);
        }
        public void CambiarFondoDeBotones(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = (Button)sender;
                if (boton.Name == "btn_Todos")
                {
                    btn_Todos.BackColor = System.Drawing.Color.Gray;
                    btn_ViajesRealizados.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                    btn_ViajesCancelados.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                }
                else
                {
                    if (boton.Name == "btn_ViajesRealizados")
                    {
                        btn_Todos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.Gray;
                        btn_ViajesCancelados.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        btn_Todos.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                        btn_ViajesRealizados.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        btn_ViajesCancelados.BackColor = System.Drawing.Color.Gray;
                    }
                }
            }
        }

    }
}
