using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Bombones.Windows.UsersControls;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

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
                Producto producto = (Producto)button.Tag!;
                int? cantidadVenta = ObtenerCantidadVenta(1);
                if (cantidadVenta is null) return;

                //What's up with the stock? later!!

                if (cantidadVenta<=producto.StockDisponible)
                {
                    DetalleVenta detalle = new DetalleVenta
                    {
                        BombonId = producto is Bombon ? producto.ProductoId : null,
                        CajaId = producto is Caja ? producto.ProductoId : null,
                        Bombon = producto is Bombon bombon ? bombon : null,
                        Caja = producto is Caja caja ? caja : null,
                        Precio = producto.PrecioVenta,
                        Cantidad = cantidadVenta.Value
                    };
                    venta!.Agregar(detalle);
                    //TODO:Tengo que actualizar el producto con el stock en pedido
                    GridHelper.MostrarDatosEnGrilla<DetalleVenta>(venta.Detalles, dgvDatos);
                    MostrarTotales();

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Stock Insuficiente"+Environment.NewLine);
                    sb.AppendFormat($"Stock disponible: {producto.StockDisponible}");
                    MessageBox.Show(sb.ToString(), "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private int? ObtenerCantidadVenta(int cantidadDefault)
        {
            while (true)
            {
                var stringCantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que compra",
                        "Cantidad del Producto", cantidadDefault.ToString());
                if (stringCantidad == null || stringCantidad == string.Empty) return null;
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
            if (ValidarDatos())
            {
                frmSeleccionarCliente frm = new frmSeleccionarCliente(_serviceProvider) { Text = "Seleccionar Cliente" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    CancelarCompra();
                    return;
                }
                Cliente? cliente = frm.GetCliente();
                venta!.ClienteId = cliente!.ClienteId != 99999 ? cliente.ClienteId : null;
                venta.Cliente = cliente;
                venta.FechaVenta = DateTime.Now;
                venta.Regalo = false;
                venta.Total = venta.GetTotal();
                venta.Estado = EstadoVenta.Pagada;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (venta.GetCantidad() == 0)
            {
                valido = false;
                errorProvider1.SetError(dgvDatos, "Ingresar al menos un ítem");
            }
            return valido;
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

        public Venta? GetVenta()
        {
            return venta;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                var filaSeleccionada = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccionada];
                DetalleVenta dt =(DetalleVenta) r.Tag!;
                DialogResult dr = MessageBox.Show("¿Anula el item seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) return;
                venta.Borrar(dt);
                GridHelper.QuitarFila(r, dgvDatos);
                MostrarTotales();
            }
            if (e.ColumnIndex==6)
            {
                var filaSeleccionada = e.RowIndex;
                var r = dgvDatos.Rows[filaSeleccionada];
                DetalleVenta dt = (DetalleVenta)r.Tag!;
                int? cantidadVendida = ObtenerCantidadVenta(dt.Cantidad);
                if (cantidadVendida is null) return;
                dt.Cantidad = cantidadVendida.Value;
                GridHelper.SetearFila(r, dt);
                MostrarTotales();
            }
        }
    }
}
