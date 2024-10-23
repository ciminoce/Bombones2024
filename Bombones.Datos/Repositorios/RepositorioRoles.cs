using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioRoles : IRepositorioRoles
    {
        public Rol? GetRolPorId(int rolId, SqlConnection conn)
        {
           
            try
            {
                var selectQuery = @"SELECT RolId, Descripcion
                        FROM Roles WHERE RolId=@id";
                return conn.QueryFirstOrDefault<Rol>(selectQuery,new { @id = rolId });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
