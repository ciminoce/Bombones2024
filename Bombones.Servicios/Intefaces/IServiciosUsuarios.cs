using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Intefaces
{
    public interface IServiciosUsuarios
    {
        Usuario? GetUsuario(string usuario, string clave);

    }
}
