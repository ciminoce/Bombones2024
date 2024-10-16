using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Bombones.Windows.UsersControls;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows.Formularios
{
    public partial class frmVentasAE : Form
    {
        private readonly IServiciosProductos? _serviciosProductos;
        private readonly IServiceProvider _serviceProvider;
        private List<Producto>? productos;
        private TipoProducto tipoProducto = TipoProducto.Bombon;

        private Venta? venta;
        public frmVentasAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _serviciosProductos = _serviceProvider.GetService<IServiciosProductos>();

        }

        private void frmVentasAE_Load(object sender, EventArgs e)
        {
            venta = new Venta();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            productos = _serviciosProductos!.GetListaProductos(tipoProducto);
            flpProductos.Controls.Clear();
            foreach (var producto in productos)
            {
                ucProducto ucProducto = new ucProducto();
                SetearUcControl(ucProducto, producto);
                AgregarUcControl(ucProducto);
            }
        }

        private void SetearUcControl(ucProducto ucProducto, Producto producto)
        {
            ucProducto.ProductoId = producto.ProductoId;
            ucProducto.NombreProducto = producto.Nombre;
            ucProducto.PrecioProducto = producto.PrecioVenta;

            ucProducto.btnAgregar.Tag = producto;

            ucProducto.btnAgregar.Click += BtnAgregar_Click;
        }

        private void BtnAgregar_Click(object? sender, EventArgs e)
        {
            if (sender is not null)
            {
                Button button = (Button)sender;
                Producto producto =(Producto) button.Tag!;
                int cantidadVenta = ObtenerCantidadVenta();
                //What's up with the stock? later!!
                //Ver de borrar algunas cantidad del detalle.. no todo
                DetalleVenta detalle = new DetalleVenta
                {
                    BombonId = producto is Bombon ? producto.ProductoId : null,
                    CajaId = producto is Caja ? producto.ProductoId : null,
                    Bombon = producto is Bombon bombon ? bombon : null,
                    Caja = producto is Caja caja ? caja : null,
                    Precio=producto.PrecioVenta,
                    Cantidad = cantidadVenta
                };
                venta!.Agregar(detalle);
                GridHelper.MostrarDatosEnGrilla<DetalleVenta>(venta.Detalles, dgvDatos);
                MostrarTotales();
            }
        }

        private int ObtenerCantidadVenta()
        {
            while (true)
            {
                var stringCantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que compra",
                        "Cantidad del Producto", "1");
                if (!int.TryParse(stringCantidad, out int cantidad) || (cantidad <= 0))
                {
                    MessageBox.Show("Cantidad mal Ingresada", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return cantidad;
                }

            } 
        }

        private void MostrarTotales()
        {
            lblTotal.Text = venta!.GetTotal().ToString();
            lblCantidad.Text = venta!.GetCantidad().ToString();
        }

        private void AgregarUcControl(ucProducto ucProducto)
        {
            flpProductos.Controls.Add(ucProducto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarCompra();
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void CancelarCompra()
        {
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            tipoProducto = TipoProducto.Caja;
            RecargarGrilla();

        }

        private void btnBombones_Click(object sender, EventArgs e)
        {
            tipoProducto = TipoProducto.Bombon;
            RecargarGrilla();
        }
    }
}
