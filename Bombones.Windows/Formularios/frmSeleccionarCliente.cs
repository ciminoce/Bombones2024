using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;

namespace Bombones.Windows.Formularios
{
    public partial class frmSeleccionarCliente : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private Cliente? cliente;
        public frmSeleccionarCliente(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboClientes(ref cboClientes,_serviceProvider);
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
