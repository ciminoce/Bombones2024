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
            MostrarDatosCaja();
            GridHelper.MostrarDatosEnGrilla<DetalleCaja>(caja.Detalles, dgvDatos);
        }

        private void MostrarDatosCaja()
        {
            txtCaja.Text = caja.Nombre;
            txtDescripcion.Text = caja.Descripcion;
            txtPrecioCosto.Text = caja.PrecioCosto.ToString();
            txtPrecioVta.Text = caja.PrecioVenta.ToString();
            nudNivel.Value = caja.NivelDeReposicion;
            nudStock.Value = caja.Stock;
            
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
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }
            var r=dgvDatos.SelectedRows[0];
            DetalleCaja detalle = (DetalleCaja)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el bombón {detalle.Bombon!.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel) return;
            caja!.Eliminar(detalle);
            GridHelper.QuitarFila(r,dgvDatos);
            MessageBox.Show("Item eliminado!!!", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditarBombon_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var r = dgvDatos.SelectedRows[0];
            DetalleCaja? detalle = (DetalleCaja)r.Tag!;
            frmManejarBombonCajaAE frm = new frmManejarBombonCajaAE(_serviceProvider) { Text = "Editar un Detalle Caja" };
            frm.SetDetalle(detalle);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            detalle = frm.GetDetalle();
            GridHelper.SetearFila(r,detalle!);
            MessageBox.Show("Item editado!!!", "Mensaje",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public Caja? GetCaja()
        {
            return caja;
        }

        public void SetCaja(Caja caja)
        {
            this.caja = caja;
        }
    }
}
