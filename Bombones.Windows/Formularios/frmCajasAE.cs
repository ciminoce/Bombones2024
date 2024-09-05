namespace Bombones.Windows.Formularios
{
    public partial class frmCajasAE : Form
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imágenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imágenes\ArchivoNoEncontrado.jpg";
        private string? archivoImagen = string.Empty;
        private string carpetaImagen = Environment.CurrentDirectory + @"\Imágenes\";


        public frmCajasAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

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

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }


        private bool ValidarDatos()
        {
            return true;
        }


        private void btnBorrarBombon_Click(object sender, EventArgs e)
        {
        }

        private void btnEditarBombon_Click(object sender, EventArgs e)
        {
        }


    }
}
