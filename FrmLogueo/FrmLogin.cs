using TransporteRodriguez;
using WF_TransporteRodriguez;

namespace FrmLogueo
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Form formulario;
            Usuario usuario = new Usuario(txt_LoginUsuario.Text, txt_Contraseña.Text);
            FactoryConcreta factoryConcreta = new FactoryConcreta();
            if ((formulario = factoryConcreta.CrearFormulario(usuario)) != null)
            {
                Frm_Cliente_Menu.Login = this;
                
                Frm_Admin_Menu.Login = this;
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados",
                    "ADVERTENCIA");
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que quiere salir?", "Cierre"
             , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.No)
            {
                //Application.Exit();
                e.Cancel = true;//para cancelar la salida
            }
        }

        private void btn_HardCodearEmpleado_Click(object sender, EventArgs e)
        {
            txt_LoginUsuario.Text = "Sofía Rodríguez";
            txt_Contraseña.Text = "contrasena123";
        }
        private void btn_HardCodearCliente_Click(object sender, EventArgs e)
        {
            txt_LoginUsuario.Text = "Javier Díaz";
            txt_Contraseña.Text = "javier333";
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            txt_LoginUsuario.Text = "María García";
            txt_Contraseña.Text = "miClaveSegura";
        }
    }
}