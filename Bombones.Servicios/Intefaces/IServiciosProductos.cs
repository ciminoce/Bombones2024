using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosProductos
    {
        void Borrar(TipoProducto tipoProducto, int productoId);
        bool EstaRelacionado(TipoProducto tipoProducto, int productoId);
        bool Existe(Producto producto);
        Producto? GetProductoPorId(TipoProducto tipoProducto,int productoId);
        int GetCantidad(TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null);
        List<ProductoListDto> GetLista(int currentPage, int pageSize,TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null );
        int GetPaginaPorRegistro(TipoProducto tipoProducto, string nombre, int pageSize);
        void Guardar(Producto producto);
        List<Producto> GetListaProductos();
    }
}
