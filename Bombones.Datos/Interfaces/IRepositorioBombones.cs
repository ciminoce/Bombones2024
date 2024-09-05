using Bombones.Entidades.Dtos;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioBombones
    {
        List<BombonListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<BombonListDto,bool>?filter=null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<BombonListDto, bool>?filter= null, SqlTransaction? tran = null);
    }
}
