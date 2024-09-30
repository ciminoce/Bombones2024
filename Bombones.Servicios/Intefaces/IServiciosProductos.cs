using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosProductos
    {
        void Borrar(int bombonId);
        bool EstaRelacionado(int bombonId);
        bool Existe(Bombon bombon);
        Bombon? GetBombonPorId(int bombonId);
        int GetCantidad(TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null);
        List<ProductoListDto> GetLista(int currentPage, int pageSize,TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null );
        int GetPaginaPorRegistro(string nombreBombon, int pageSize);
        void Guardar(Bombon bombon);
    }
}
