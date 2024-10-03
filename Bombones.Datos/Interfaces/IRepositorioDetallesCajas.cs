using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioDetallesCajas
    {
        void Agregar(DetalleCaja detalle, SqlConnection conn, SqlTransaction tran);
        void Borrar(int productoId, SqlConnection conn, SqlTransaction tran);

    }
}
