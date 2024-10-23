using Bombones.Datos.Interfaces;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosUsuarios : IServiciosUsuarios
    {
        private readonly IRepositorioUsuarios? _repositorio;
        private readonly string? _cadena;

        public ServiciosUsuarios(IRepositorioUsuarios? repositorio,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }

        public Usuario? GetUsuario(string usuario, string clave)
        {
            using (var conn=new SqlConnection(_cadena))
            {
                return _repositorio!.GetUsuario(usuario, clave,conn);
            }
        }
    }
}
