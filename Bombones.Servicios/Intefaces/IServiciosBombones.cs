using Bombones.Entidades.Dtos;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosBombones
    {
        int GetCantidad(Func<BombonListDto, bool>? filter = null);
        List<BombonListDto> GetLista(int currentPage, int pageSize,Func<BombonListDto, bool>? filter = null );

    }
}
