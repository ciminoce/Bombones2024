using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;

namespace Bombones.Windows.Formularios
{
    public partial class frmSeleccionarCliente : Form
    {
        private Cliente? cliente;
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //CombosHelper.CargarComboClientes(ref cboClientes);
        }

        public Cliente? GetCliente()
        {
            return cliente;
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = (Cliente?)cboClientes.SelectedItem;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
