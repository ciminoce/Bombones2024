using Bombones.Datos.Interfaces;
using Bombones.Datos.Repositorios;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosVentas : IServiciosVentas
    {
        private readonly IRepositorioVentas _repositorio;
        private readonly IRepositorioDetallesVentas? _repositorioDetalles;
        private readonly string? _cadena;

        public ServiciosVentas(IRepositorioVentas? repositorio,
            IRepositorioDetallesVentas repositorioDetalles,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _repositorioDetalles = repositorioDetalles ?? throw new ApplicationException("Dependencias no cargadas!!!");

            _cadena = cadena;
        }

        public int GetCantidad(Func<VentaListDto, bool>? filter)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }

        }

        public List<VentaListDto> GetLista(int currentPage, int pageSize, Func<VentaListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, currentPage, pageSize, filter);
            }

        }

        public Venta? GetVentaPorId(int ventaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetVentaPorId(conn, ventaId);
            }
        }

        public void Guardar(Venta? venta)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (venta.VentaId == 0)
                        {
                            _repositorio!.Agregar(venta, conn, tran);

                            foreach (var item in venta.Detalles)
                            {
                                item.VentaId = venta.VentaId;
                                _repositorioDetalles!.Agregar(item, conn, tran);
                            }

                        }
                        else
                        {

                            _repositorio!.Editar(venta, conn, tran);
                            //TODO: Ver lo que quiere hacer Octavio
                            //foreach (var item in caja.Detalles)
                            //{
                            //    item.CajaId = caja.ProductoId;
                            //    _repositorioDetallesCajas.Agregar(item, conn, tran);
                            //}
                            //_repositorioDetallesCajas!.Borrar(caja.ProductoId, conn, tran);

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
    }
}
