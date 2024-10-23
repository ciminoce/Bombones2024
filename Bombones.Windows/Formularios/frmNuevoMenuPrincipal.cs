using Bombones.Entidades.Entidades;
using Bombones.Windows.Formularios;
using System.Windows.Forms;

namespace Bombones.Windows
{
    public partial class frmNuevoMenuPrincipal : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Usuario? user;
        public frmNuevoMenuPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        public void SetUsuario(Usuario usuario)
        {
            user = usuario;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblUsuario.Text = user.NombreUsuario;
            HabilitarMenu();
        }

        private void HabilitarMenu()
        {
            // toolStrip es el ToolStrip que estás usando
            foreach (ToolStripItem item in BarraMenu.Items)
            {
                // Verificar si el ToolStripItem tiene una propiedad Text
                if (!string.IsNullOrEmpty(item.Text))
                {
                    // Comprobar si el texto del ToolStripItem existe dentro de los permisos del usuario
                    bool tienePermiso = user.Rol.Permisos.Any(p => p.Permiso.Menu == item.Text);

                    // Si tiene permiso, puedes habilitar o mostrar el item
                    if (tienePermiso)
                    {
                        item.Enabled = true;  // O alguna acción específica
                    }
                    else
                    {
                        item.Enabled = false; // O lo que quieras hacer si no tiene permiso
                    }
                }
            }
        }
        private void rellenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRellenos frm = new frmRellenos(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void nuecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNueces frm = new frmNueces(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void chocolatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmChocolates(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void paísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPaises(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmProvinciasEstados(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCiudades(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void tsbClientes_Click(object sender, EventArgs e)
        {
            var frm = new frmClientes(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void bombonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBombones(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCajas(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }

        private void tsbVentas_Click(object sender, EventArgs e)
        {
            var frm = new frmVentas(_serviceProvider);
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
