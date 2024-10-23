using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioDetallesVentas
    {
        void Agregar(DetalleVenta detalle, SqlConnection conn, SqlTransaction tran);
    }
}
