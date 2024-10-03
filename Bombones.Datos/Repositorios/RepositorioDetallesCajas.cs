using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioDetallesCajas : IRepositorioDetallesCajas
    {
        public RepositorioDetallesCajas()
        {
            
        }
        public void Agregar(DetalleCaja detalle, SqlConnection conn, SqlTransaction tran)
        {
            /*
             * Como dijo el meyi (Octavio) ver el stock del bombon
             */
            string insertQuery = @"INSERT INTO DetallesCajas
                (CajaId, BombonId, Cantidad) 
                VALUES (@CajaId, @BombonId, @Cantidad); 
                SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, detalle, tran);
            if (primaryKey > 0)
            {
                detalle.DetalleCajaId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el Detalle");

        }

        public void Borrar(int productoId, SqlConnection conn, SqlTransaction tran)
        {
            var deleteQuery = @"DELETE FROM DetallesCajas 
                WHERE CajaId=@CajaId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { @CajaId=productoId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudieron borrar los detalles de la caja");
            }

        }
    }
}
