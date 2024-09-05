using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosBombones : IServiciosBombones
    {
        private readonly IRepositorioBombones? _repositorio;
        private readonly string? _cadena;

        public ServiciosBombones(IRepositorioBombones? repositorio,
            string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }

        public int GetCantidad(Func<BombonListDto, bool>? filter = null)
        {
            using(var conn=new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }

        //public List<BombonListDto> GetLista()
        //{
        //    using (var conn = new SqlConnection(_cadena))
        //    {
        //        conn.Open();
        //        return _repositorio!.GetLista(conn);
        //    }

        //}

        public List<BombonListDto> GetLista(int currentPage, int pageSize, 
            Func<BombonListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn,currentPage,pageSize,filter);
            }
        }
    }
}
