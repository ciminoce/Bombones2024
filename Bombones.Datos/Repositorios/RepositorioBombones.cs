using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioBombones : IRepositorioBombones
    {
        public int GetCantidad(SqlConnection conn, Func<BombonListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM Bombones";
            var query=conn.Query<BombonListDto>(selectQuery).ToList();
            if (filter != null)
            {
                query = query.Where(filter).ToList();
            }
            return query.Count;
        }


        public List<BombonListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<BombonListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT b.BombonId, 
                                   b.NombreBombon, 
                                   tc.Descripcion AS TipoDeChocolate, 
                                   tn.Descripcion AS TipoDeNuez, 
                                   tr.Descripcion AS TipoDeRelleno, 
                                   f.NombreFabrica AS Fabrica, 
                                   b.Stock, 
                                   b.PrecioVenta AS Precio
                            FROM Bombones b 
                            INNER JOIN TiposDeChocolates tc ON b.TipoDeChocolateId = tc.TipoDeChocolateId
                            INNER JOIN TiposDeNueces tn ON b.TipoDeNuezId = tn.TipoDeNuezId
                            INNER JOIN TiposDeRellenos tr ON b.TipoDeRellenoId = tr.TipoDeRellenoId
                            INNER JOIN Fabricas f ON b.FabricaId = f.FabricaId";
            var lista = conn.Query<BombonListDto>(selectQuery).ToList();
            if (filter != null)
            {
                lista = lista.Where(filter).ToList();
            }
            return lista.Skip((currentPage-1)*pageSize).Take(pageSize).ToList();
        }
    }
}
