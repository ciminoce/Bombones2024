using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows.Formularios
{
    public partial class frmCajas : Form
    {
        private List<ProductoListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        private Func<ProductoListDto, bool>? filter = null;

        private TipoProducto tipoProducto = TipoProducto.Caja;

        public frmCajas(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;

        }

        private void frmCajas_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                totalRecords = _servicio!.GetCantidad(tipoProducto, filter);
                totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                LoadData(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadData(Func<ProductoListDto, bool>? filter = null)
        {
            try
            {
                lista = _servicio!.GetLista(currentPage, pageSize, tipoProducto, filter);
                if (lista.Count > 0)
                {
                    GridHelper.MostrarDatosEnGrilla<ProductoListDto>(lista,dgvDatos);
                    if (cboPaginas.Items.Count != totalPages)
                    {
                        CombosHelper.CargarComboPaginas(ref cboPaginas, totalPages);
                    }
                    txtCantidadPaginas.Text = totalPages.ToString();
                    cboPaginas.SelectedIndexChanged -= cboPaginas_SelectedIndexChanged;
                    cboPaginas.SelectedIndex = currentPage == 1 ? 0 : currentPage - 1;
                    cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;

                }
                else
                {
                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentPage = 1;
                    filter = null;
                    tsbFiltrar.Enabled = true;
                    tsbFiltrar.BackColor = SystemColors.Control;
                    RecargarGrilla();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData( filter);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(filter);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            LoadData(filter);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData( filter);
            }
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = int.Parse(cboPaginas.Text);
            LoadData(filter);
        }




        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            tsbFiltrar.BackColor = SystemColors.Control;
            RecargarGrilla();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCajasAE frm = new frmCajasAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Caja? caja = frm.GetCaja();
                if (caja is null) return;
                if (!_servicio!.Existe(caja))
                {
                    _servicio.Guardar(caja);


                    totalRecords = _servicio?.GetCantidad(tipoProducto) ?? 0;
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicio?.GetPaginaPorRegistro(tipoProducto, caja.Nombre, pageSize) ?? 0;
                    LoadData();

                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente\nAlta denegada",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }


        }


        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbDetalles_Click(object sender, EventArgs e)
        {

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var cajaDto = (CajaListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja la caja {cajaDto.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (!_servicio!.EstaRelacionado(tipoProducto,cajaDto.ProductoId))
                {
                    _servicio!.Borrar(tipoProducto,cajaDto.ProductoId);
                    totalRecords = _servicio!.GetCantidad(tipoProducto);
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (currentPage > totalPages) currentPage = totalPages; // Ajustar la página actual si se reduce el total de páginas

                    LoadData();
                    MessageBox.Show("Registro eliminado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro relacionado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
