using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bombones.Windows.Formularios
{
    public partial class frmBombones : Form
    {
        private List<ProductoListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        private Func<ProductoListDto, bool>? filter = null;

        private TipoProducto tipoProducto = TipoProducto.Bombon;
        public frmBombones(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmBombones_Load(object sender, EventArgs e)
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
                    GridHelper.MostrarDatosEnGrilla<ProductoListDto>(lista, dgvDatos);
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
                LoadData( filter);
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
            LoadData( filter);
        }




        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            filter = null;
            currentPage = 1;
            tsbFiltrar.Enabled = true;
            tsbFiltrar.BackColor = SystemColors.Control;
            RecargarGrilla();
        }

        private void nombreBombónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltroTexto frm = new frmFiltroTexto() { Text = "Ingresar texto para buscar..." };
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                var textoFiltro = frm.GetTexto();
                if (textoFiltro is null || textoFiltro == string.Empty)
                {
                    return;
                }
                filter = b => b.Nombre.ToUpper()
                    .Contains(textoFiltro.ToUpper());
                totalRecords = _servicio!.GetCantidad(tipoProducto, filter);
                currentPage = 1;
                if (totalRecords > 0)
                {
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    tsbFiltrar.Enabled = false;
                    tsbFiltrar.BackColor = Color.Orange;

                    LoadData( filter);

                }
                else
                {

                    MessageBox.Show("No se encontraron registros!!!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    filter = null;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmBombonesAE frm = new frmBombonesAE(_serviceProvider);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                Bombon? bombon = frm.GetBombon();
                if (bombon is null) return;
                if (!_servicio!.Existe(bombon))
                {
                    _servicio.Guardar(bombon);


                    totalRecords = _servicio?.GetCantidad(tipoProducto) ?? 0;
                    totalPages = (int)Math.Ceiling((decimal)totalRecords / pageSize);
                    currentPage = _servicio?.GetPaginaPorRegistro(tipoProducto, bombon.Nombre, pageSize) ?? 0;
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

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var bombonDto = (BombonListDto)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el bombon {bombonDto.Nombre}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            try
            {
                if (!_servicio!.EstaRelacionado(tipoProducto,bombonDto.ProductoId))
                {
                    _servicio!.Borrar(tipoProducto,bombonDto.ProductoId);
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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) return;
            BombonListDto bombonDto = (BombonListDto)r.Tag;
            Producto? bombon = _servicio!.GetProductoPorId(tipoProducto,bombonDto.ProductoId);
            if (bombon is null) return;
            frmBombonesAE frm = new frmBombonesAE(_serviceProvider) { Text = "Editar Bombon" };
            frm.SetBombon((Bombon)bombon!);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            bombon = frm.GetBombon();

            if (bombon == null) return;
            try
            {

                if (!_servicio!.Existe(bombon))
                {
                    _servicio!.Guardar(bombon);


                    currentPage = _servicio!.GetPaginaPorRegistro(tipoProducto,bombon.Nombre, pageSize);
                    LoadData();
                    int row = GridHelper.ObtenerRowIndex(dgvDatos, bombon.ProductoId);
                    GridHelper.MarcarRow(dgvDatos, row);
                    MessageBox.Show("Registro editado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro existente\nEdición denegada",
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

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
