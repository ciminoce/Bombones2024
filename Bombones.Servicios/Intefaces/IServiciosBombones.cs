using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosBombones
    {
        void Borrar(int bombonId);
        bool EstaRelacionado(int bombonId);
        bool Existe(Bombon bombon);
        Bombon? GetBombonPorId(int bombonId);
        int GetCantidad(Func<BombonListDto, bool>? filter = null);
        List<BombonListDto> GetLista(int currentPage, int pageSize,Func<BombonListDto, bool>? filter = null );
        int GetPaginaPorRegistro(string nombreBombon, int pageSize);
        void Guardar(Bombon bombon);
    }
}
