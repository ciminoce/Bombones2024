using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosVentas : IServiciosVentas
    {
        private readonly IRepositorioVentas _repositorio;
        private readonly string? _cadena;

        public ServiciosVentas(IRepositorioVentas? repositorio,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");

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
    }
}
