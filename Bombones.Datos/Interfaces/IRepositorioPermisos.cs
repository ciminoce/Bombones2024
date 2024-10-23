using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioPermisos
    {
        List<Permiso>? GetPermisos(int rolId, SqlConnection conn);
    }
}
