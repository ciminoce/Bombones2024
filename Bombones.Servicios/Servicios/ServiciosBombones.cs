using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
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

        public void Borrar(int bombonId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(bombonId, conn, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool EstaRelacionado(int bombonId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(bombonId, conn);
            }

        }

        public bool Existe(Bombon bombon)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(bombon, conn);
            }

        }

        public Bombon? GetBombonPorId(int bombonId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.GetBombonPorId(bombonId, conn);
            }

        }

        public int GetCantidad(Func<BombonListDto, bool>? filter = null)
        {
            using(var conn=new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, filter);
            }
        }


        public List<BombonListDto> GetLista(int currentPage, int pageSize, 
            Func<BombonListDto, bool>? filter = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn,currentPage,pageSize,filter);
            }
        }

        public int GetPaginaPorRegistro(string nombreBombon, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!
                    .GetPaginaPorRegistro(conn, nombreBombon, pageSize);
            }
        }


        public void Guardar(Bombon bombon)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (bombon.ProductoId == 0)
                        {
                            _repositorio!.Agregar(bombon, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(bombon, conn, tran);
                        }

                        tran.Commit();//guarda efectivamente
                    }
                    catch (Exception)
                    {
                        tran.Rollback();//tira todo pa tras!!!
                        throw;
                    }
                }
            }
        }
    }
}
