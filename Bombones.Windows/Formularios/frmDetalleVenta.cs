using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;

namespace Bombones.Windows.Formularios
{
    public partial class frmDetalleVenta : Form
    {
        private Venta? venta;
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        public void SetVenta(Venta? venta)
        {
            this.venta = venta;
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarVenta();
            GridHelper.MostrarDatosEnGrilla<DetalleVenta>(venta!.Detalles, dgvDatos);
        }

        private void MostrarVenta()
        {
            txtCliente.Text = $"{venta.Cliente!.Nombres} {venta.Cliente.Apellido}";
            txtFecha.Text = $"{venta.FechaVenta.ToShortDateString()}";
            txtVentaNro.Text = $"{venta.VentaId}";
            txtTotal.Text = $"{venta.Total}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
