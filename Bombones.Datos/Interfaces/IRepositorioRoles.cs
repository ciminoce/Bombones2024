using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioRoles
    {
        Rol? GetRolPorId(int rolId, SqlConnection conn);
    }
}
