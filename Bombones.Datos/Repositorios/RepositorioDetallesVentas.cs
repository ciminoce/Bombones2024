using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioDetallesVentas : IRepositorioDetallesVentas
    {
        public void Agregar(DetalleVenta detalle, SqlConnection conn, SqlTransaction tran)
        {
            string insertQuery = @"INSERT INTO DetallesVentas 
                (VentaId, BombonId, CajaId, Cantidad, Precio) 
                VALUES (@VentaId, @BombonId, @CajaId, @Cantidad, @Precio); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, detalle, tran);
            if (primaryKey > 0)
            {
                detalle.DetalleVentaId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el detalle de venta");
        }
    }
}
