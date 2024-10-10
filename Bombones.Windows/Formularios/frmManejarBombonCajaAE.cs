using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;

namespace Bombones.Windows.Formularios
{
    public partial class frmManejarBombonCajaAE : Form
    {
        private readonly IServiceProvider? serviceProvider;
        private DetalleCaja? detalleCaja;
        private Bombon? bombonSeleccionado;
        public frmManejarBombonCajaAE(IServiceProvider? _serviceProvider)
        {
            InitializeComponent();
            serviceProvider = _serviceProvider;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboBombones(ref cboBombones, serviceProvider);
            if (detalleCaja is not null)
            {
                cboBombones.SelectedValue = detalleCaja.BombonId;
                nudCantidad.Value = detalleCaja.Cantidad;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (detalleCaja is null)
                {
                    detalleCaja = new DetalleCaja();
                }
                detalleCaja.BombonId = bombonSeleccionado!.ProductoId;
                detalleCaja.Cantidad = (int)nudCantidad.Value;
                detalleCaja.Bombon = bombonSeleccionado;
                bombonSeleccionado = detalleCaja.Bombon;
                DialogResult=DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (cboBombones.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(cboBombones, "Debe seleccionar un bombón");
            }
            return valido;
        }

        private void cboBombones_SelectedIndexChanged(object sender, EventArgs e)
        {
            bombonSeleccionado = cboBombones.SelectedIndex > 0 ? (Bombon)cboBombones.SelectedItem! : null;
        }

        public DetalleCaja? GetDetalle()
        {
            return detalleCaja;
        }

        public void SetDetalle(DetalleCaja detalleCaja)
        {
            this.detalleCaja = detalleCaja;
        }
    }
}
