using TransporteRodriguez;
using WF_TransporteRodriguez;

namespace FrmLogueo
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            cbo_Rol.SelectedIndex = 0;

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Empleado usuario = new Empleado(txt_LoginUsuario.Text, txt_Contraseņa.Text);
            if (Sistema.ValidarUsuario(usuario))
            {
                FrmMenuEmpleado menuEmpleado = new FrmMenuEmpleado();//INSTANCIO AL USUARIO
                menuEmpleado.Show();
                this.Hide();//Para "esconder" al login
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Sistema.AgregarCliente();
            Sistema.AgregarEmpleado();
        }
    }
}