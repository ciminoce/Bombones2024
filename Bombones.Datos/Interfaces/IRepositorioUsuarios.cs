using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioUsuarios
    {
        Usuario? GetUsuario(string usuario, string clave, SqlConnection conn);
    }
}
