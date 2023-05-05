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
            Usuario usuario = new Usuario(txt_LoginUsuario.Text, txt_Contraseña.Text);
            Usuario usuarioAuxiliar;
            usuarioAuxiliar = Sistema.ValidarUsuario(usuario);
            if (usuarioAuxiliar != null && usuarioAuxiliar is Empleado)
            {
                FrmMenuEmpleado menuEmpleado = new FrmMenuEmpleado();//INSTANCIO AL EMPLEADO
                menuEmpleado.UsuarioInstanciado = usuarioAuxiliar;
                menuEmpleado.Show();
                this.Hide();//Para "esconder" al login
            }
            else
            {
                if (usuarioAuxiliar != null && usuarioAuxiliar is Cliente)
                {
                    FrmMenuCliente menuEmpleado = new FrmMenuCliente();//INSTANCIO AL CLIENTE
                    menuEmpleado.UsuarioInstanciado = usuarioAuxiliar;
                    menuEmpleado.Show();
                    this.Hide();//Para "esconder" al login
                }
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Sistema.AgregarCliente();
            Sistema.AgregarEmpleado();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dialog resulta es un enumerado
            DialogResult confirmacion = MessageBox.Show("Esta seguro que quiere salir?", "Cierre"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.No)
            {
                // Application.Exit();
                e.Cancel = true;//para cancelar la salida
            }
        }
    }
}