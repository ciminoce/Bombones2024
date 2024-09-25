using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioBombones
    {
        List<BombonListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<BombonListDto,bool>?filter=null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Func<BombonListDto, bool>?filter= null, SqlTransaction? tran = null);
        void Borrar(int bombonId, SqlConnection conn, SqlTransaction tran);
        bool EstaRelacionado(int bombonId, SqlConnection conn);
        bool Existe(Bombon bombon, SqlConnection conn);
        Bombon? GetBombonPorId(int bombonId, SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, string nombreBombon, int pageSize);
        void Agregar(Bombon bombon, SqlConnection conn, SqlTransaction tran);
        void Editar(Bombon bombon, SqlConnection conn, SqlTransaction tran);
    }
}
