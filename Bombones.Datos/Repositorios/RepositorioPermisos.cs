using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioPermisos : IRepositorioPermisos
    {
        public List<Permiso>? GetPermisos(int rolId, SqlConnection conn)
        {
            List<Permiso> lista = new List<Permiso>();
            try
            {
                var selectQuery = @"SELECT PermisoId, NombreMenu 
                        FROM Permisos WHERE RolId=@id";
                return conn.Query<Permiso>(selectQuery,new {@id=rolId}).ToList();
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
    }
}
