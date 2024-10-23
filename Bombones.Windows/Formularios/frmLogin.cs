using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows
{
    public partial class frmLogin : Form
    {
        private readonly IServiceProvider? serviceProvider;
        private readonly IServiciosUsuarios? _servicios;
        private Usuario? user;
        public frmLogin(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            _servicios = serviceProvider!.GetService<IServiciosUsuarios>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNuevoMenuPrincipal frm = new frmNuevoMenuPrincipal(serviceProvider);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = _servicios.GetUsuario(txtUsuario.Text, txtClave.Text);
            if (user != null)
            {
                this.Hide();
                var frm = new frmNuevoMenuPrincipal(serviceProvider);
                frm.FormClosing += Frm_FormClosing;
                frm.SetUsuario(user);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado" + Environment.NewLine + "o clave errónea",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LimpiarTextos();
            }

        }

        private void LimpiarTextos()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtUsuario.Focus();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            LimpiarTextos();
        }
    }
}
