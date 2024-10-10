using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos? _repositorio;
        private readonly IRepositorioDetallesCajas? _repositorioDetallesCajas;
        private readonly string? _cadena;

        public ServiciosProductos(IRepositorioProductos? repositorio,
            IRepositorioDetallesCajas repositorioDetallesCajas,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _repositorioDetallesCajas = repositorioDetallesCajas ?? throw new ApplicationException("Dependencias no cargadas!!!");

            _cadena = cadena;
        }

        public void Borrar(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (tipoProducto is TipoProducto.Caja)
                        {
                            _repositorioDetallesCajas!.Borrar(productoId, conn, tran);
                        }
                        _repositorio!.Borrar(tipoProducto, productoId, conn, tran);

                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool EstaRelacionado(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(tipoProducto, productoId, conn);
            }

        }

        public bool Existe(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(producto, conn);
            }

        }

        public Producto? GetProductoPorId(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.GetProductoPorId(tipoProducto,productoId, conn);
            }

        }

        public int GetCantidad(TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, tipoProducto, filter);
            }
        }


        public List<ProductoListDto> GetLista(int currentPage, int pageSize, TipoProducto tipoProducto,
            Func<ProductoListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, tipoProducto, filter);
            }
        }

        public int GetPaginaPorRegistro(TipoProducto tipoProducto, string nombre, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!
                    .GetPaginaPorRegistro(conn, tipoProducto, nombre, pageSize);
            }
        }


        public void Guardar(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (producto.ProductoId == 0)
                        {
                            _repositorio!.Agregar(producto, conn, tran);
                            if (producto is Caja caja)
                            {
                                foreach (var item in caja.Detalles)
                                {
                                    item.CajaId = caja.ProductoId;
                                    _repositorioDetallesCajas!.Agregar(item, conn, tran);
                                }
                            }
                        }
                        else
                        {

                            _repositorio!.Editar(producto, conn, tran);
                            if (producto is Caja caja)
                            {
                                _repositorioDetallesCajas!.Borrar(caja.ProductoId, conn, tran);
                                foreach (var item in caja.Detalles)
                                {
                                    item.CajaId = caja.ProductoId;
                                    _repositorioDetallesCajas.Agregar(item, conn, tran);
                                }

                            }
                        }

                        tran.Commit();//guarda efectivamente
                    }
                    catch (Exception)
                    {
                        tran.Rollback();//tira todo pa tras!!!
                        throw;
                    }
                }
            }
        }

        public List<Producto> GetListaProductos()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetListaProductos(conn);
            }
        }
    }
}
