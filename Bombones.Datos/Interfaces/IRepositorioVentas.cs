using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioVentas
    {
        int GetCantidad(SqlConnection conn, Func<VentaListDto, bool>? filter);
        List<VentaListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<VentaListDto, bool>? filter = null, SqlTransaction? tran = null);
        Venta? GetVentaPorId(SqlConnection conn, int ventaId, SqlTransaction? tran = null);
    }
}
