namespace Bombones.Windows.UsersControls
{
    public partial class ucProducto : UserControl
    {
        public ucProducto()
        {
            InitializeComponent();
        }
        public int ProductoId { get; set; }
        public string? NombreProducto { set => lblNombreProducto.Text = value; }
        public decimal PrecioProducto { set => lblPrecioProducto.Text = value.ToString(); }
        public string? ImagenProducto { get; set; }

        private void ucProducto_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Aquamarine;
        }

        private void ucProducto_MouseLeave(object sender, EventArgs e)
        {
            BackColor=Color.White;
        }
    }
}
