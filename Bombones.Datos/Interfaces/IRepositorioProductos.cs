using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioProductos
    {
        List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, TipoProducto tipoProducto, Func<ProductoListDto,bool>?filter=null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn,TipoProducto tipoProducto, Func<ProductoListDto, bool>?filter= null, SqlTransaction? tran = null);
        void Borrar(int bombonId, SqlConnection conn, SqlTransaction tran);
        bool EstaRelacionado(int bombonId, SqlConnection conn);
        bool Existe(Bombon bombon, SqlConnection conn);
        Bombon? GetBombonPorId(int bombonId, SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, string nombreBombon, int pageSize);
        void Agregar(Bombon bombon, SqlConnection conn, SqlTransaction tran);
        void Editar(Bombon bombon, SqlConnection conn, SqlTransaction tran);
    }
}
