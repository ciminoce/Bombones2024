using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosVentas
    {
        int GetCantidad(Func<VentaListDto, bool>? filter);
        List<VentaListDto> GetLista(int currentPage, int pageSize, Func<VentaListDto, bool>? filter = null);
        Venta? GetVentaPorId(int ventaId);
        void Guardar(Venta? venta);
    }
}
