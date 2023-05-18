using FrmLogueo;
using Microsoft.VisualBasic.Logging;
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
    public partial class Frm_Admin_Menu : Form
    {
        private Empleado empleadoInstanciado;
        private static Frm_Login login;
        public Frm_Admin_Menu()
        {
            InitializeComponent();
        }

        public Empleado EmpleadoInstanciado { get => empleadoInstanciado; set => empleadoInstanciado = value; }
        public static Frm_Login Login { get => login; set => login = value; }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Datos frm_Empleado_Datos = new Frm_Empleado_Datos();
            Repositorio_Empleados repositorio_Empleados = new Repositorio_Empleados();
            frm_Empleado_Datos.Empleado = EmpleadoInstanciado;
            frm_Empleado_Datos.MdiParent = this;
            frm_Empleado_Datos.Dock = DockStyle.Fill;
            frm_Empleado_Datos.Show();


        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Login.Show();
        }

        private void Frm_Admin_Menu_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = empleadoInstanciado.Nombre;
            Frm_Hora frm_Hora = new Frm_Hora();
            frm_Hora.MdiParent = this;
            frm_Hora.Dock = DockStyle.Fill;
            frm_Hora.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta_Cliente frm_Empleado_Alta_Cliente = new Frm_Empleado_Alta_Cliente();
            frm_Empleado_Alta_Cliente.MdiParent = this;
            frm_Empleado_Alta_Cliente.Dock = DockStyle.Fill;
            frm_Empleado_Alta_Cliente.Show();
        }

        private void moToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Modificacion_Cliente frm_Empleado_Modificacion_Cliente = new Frm_Empleado_Modificacion_Cliente();
            frm_Empleado_Modificacion_Cliente.MdiParent = this;
            frm_Empleado_Modificacion_Cliente.Dock = DockStyle.Fill;
            frm_Empleado_Modificacion_Cliente.Show();
        }

        private void bajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Baja_Cliente frm_Empleado_Baja_Cliente = new Frm_Empleado_Baja_Cliente();
            frm_Empleado_Baja_Cliente.MdiParent = this;
            frm_Empleado_Baja_Cliente.Dock = DockStyle.Fill;
            frm_Empleado_Baja_Cliente.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Listar_Clientes frm_Empleado_Listar_Clientes = new Frm_Empleado_Listar_Clientes();
            frm_Empleado_Listar_Clientes.MdiParent = this;
            frm_Empleado_Listar_Clientes.Dock = DockStyle.Fill;
            frm_Empleado_Listar_Clientes.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Alta_Vehiculo frm_Empleado_Alta_Vehiculo = new Frm_Empleado_Alta_Vehiculo();
            frm_Empleado_Alta_Vehiculo.MdiParent = this;
            frm_Empleado_Alta_Vehiculo.Dock = DockStyle.Fill;
            frm_Empleado_Alta_Vehiculo.Show();
        }

        private void bajaVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Baja_Vehiculo frm_Empleado_Baja_Vehiculo = new Frm_Empleado_Baja_Vehiculo();
            frm_Empleado_Baja_Vehiculo.MdiParent = this;
            frm_Empleado_Baja_Vehiculo.Dock = DockStyle.Fill;
            frm_Empleado_Baja_Vehiculo.Show();
        }

        private void listarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleados_Lista_Vehiculos Frm_Empleados_Lista_Vehiculos = new Frm_Empleados_Lista_Vehiculos();
            Frm_Empleados_Lista_Vehiculos.MdiParent = this;
            Frm_Empleados_Lista_Vehiculos.Dock = DockStyle.Fill;
            Frm_Empleados_Lista_Vehiculos.Show();
        }

        private void turnosOcupadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Empleado_Lista_Viajes frm_Empleado_Lista_Viajes = new Frm_Empleado_Lista_Viajes();
            frm_Empleado_Lista_Viajes.MdiParent = this;
            frm_Empleado_Lista_Viajes.Dock = DockStyle.Fill;
            frm_Empleado_Lista_Viajes.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Admin_Alta_Empleado frm_Admin_Alta_Empleado = new Frm_Admin_Alta_Empleado();
            frm_Admin_Alta_Empleado.MdiParent = this;
            frm_Admin_Alta_Empleado.Dock = DockStyle.Fill;
            frm_Admin_Alta_Empleado.Show();
        }
    }
}
