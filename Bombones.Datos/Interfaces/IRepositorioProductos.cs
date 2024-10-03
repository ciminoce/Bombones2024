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
        void Borrar(TipoProducto tipoProducto,int ProductoId, SqlConnection conn, SqlTransaction tran);
        bool EstaRelacionado(TipoProducto tipoProducto, int ProductoId, SqlConnection conn);
        bool Existe(Producto producto, SqlConnection conn);
        Producto? GetProductoPorId(TipoProducto tipoProducto, int ProductoId, SqlConnection conn);
        int GetPaginaPorRegistro(SqlConnection conn, TipoProducto tipoProducto, string nombre, int pageSize);
        void Agregar(Producto producto, SqlConnection conn, SqlTransaction tran);
        void Editar(Producto producto, SqlConnection conn, SqlTransaction tran);
        List<Producto> GetListaProductos(SqlConnection conn);
    }
}
