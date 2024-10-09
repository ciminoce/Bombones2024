using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows.Formularios
{
    public partial class frmCajasAE : Form
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";

        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosProductos? _servicios;

        private Caja? caja;
        public frmCajasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicios=_serviceProvider!.GetRequiredService<IServiciosProductos>()??
                throw new ApplicationException("Dependencias no cargadas");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (caja is null)
            {
                caja = new Caja();
            }
        }

        private void CargarDetallesEnCarrito()
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAgregarBombon_Click(object sender, EventArgs e)
        {
            frmManejarBombonCajaAE frm = new frmManejarBombonCajaAE(_serviceProvider) { Text = "Agregar Bombón" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            DetalleCaja? detalle = frm.GetDetalle();
            if (detalle is null) return;

            if (caja!.Existe(detalle))
            {
                DialogResult drDetalle = MessageBox.Show(
                    $"¿Desea agregar la cantidad al bombón {detalle.Bombon!.Nombre}?", "Detalle Existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (drDetalle==DialogResult.Yes)
                {
                    caja!.Agregar(detalle);

                }

            }
            else
            {
                caja!.Agregar(detalle);
            }
            GridHelper.MostrarDatosEnGrilla<DetalleCaja>(caja.Detalles, dgvDatos);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                caja!.Nombre = txtCaja.Text;
                caja.Descripcion = txtDescripcion.Text;
                caja.PrecioCosto = decimal.Parse(txtPrecioCosto.Text);
                caja.PrecioVenta=decimal.Parse(txtPrecioVta.Text);
                caja.Stock = (int)nudStock.Value;
                caja.NivelDeReposicion = (int)nudNivel.Value;

                DialogResult = DialogResult.OK;
            }
        }


        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(txtCaja.Text))
            {
                valido = false;
                errorProvider1.SetError(txtCaja, "Nombre de caja es requerido");
            }
            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal precioCosto) ||
                (precioCosto <= 0)) {
                valido = false;
                errorProvider1.SetError(txtPrecioCosto, "Precio de costo mal ingresado");
            }
            if (!decimal.TryParse(txtPrecioVta.Text, out decimal precioVenta) ||
                    (precioVenta <= precioCosto))
            {
                valido = false;
                errorProvider1.SetError(txtPrecioVta, "Precio de vta. mal ingresado");
            }

            if (caja!.Detalles.Count==0)
            {
                valido = false;
                errorProvider1.SetError(dgvDatos, "Debe tener al menos un item");
            }
            return valido;
        }


        private void btnBorrarBombon_Click(object sender, EventArgs e)
        {
        }

        private void btnEditarBombon_Click(object sender, EventArgs e)
        {
        }

        public Caja? GetCaja()
        {
            return caja;
        }
    }
}
