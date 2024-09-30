using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Entidades.Enumeraciones;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        public void Agregar(Bombon bombon, SqlConnection conn, SqlTransaction tran)
        {
            var insertQuery = @"INSERT INTO Bombones (NombreBombon, Descripcion, TipoDeChocolateId, 
                        TipoDeNuezId, TipoDeRellenoId, PrecioCosto, PrecioVenta, Stock, 
                        NivelDeReposicion, Imagen, FabricaId, Suspendido) VALUES 
                        (@NombreBombon, @Descripcion, @TipoDeChocolateId, @TipoDeNuezId, 
                        @TipoDeRellenoId, @PrecioCosto, @PrecioVenta, @Stock, 
                        @NivelDeReposicion, @Imagen, @FabricaId, @Suspendido); 
                        SELECT CAST(SCOPE_IDENTITY() as int)";

            int primaryKey = conn.QuerySingle<int>(insertQuery, new
            {
                NombreBombon = bombon.Nombre, 
                Descripcion = bombon.Descripcion,
                TipoDeChocolateId = bombon.TipoDeChocolateId,
                TipoDeNuezId = bombon.TipoDeNuezId,
                TipoDeRellenoId = bombon.TipoDeRellenoId,
                PrecioCosto = bombon.PrecioCosto,
                PrecioVenta = bombon.PrecioVenta,
                Stock = bombon.Stock,
                NivelDeReposicion = bombon.NivelDeReposicion,
                Imagen = bombon.Imagen,
                FabricaId = bombon.FabricaId,
                Suspendido = bombon.Suspendido
            }, tran);

            if (primaryKey > 0)
            {
                bombon.ProductoId = primaryKey;
                return;
            }
            throw new Exception("No se pudo agregar el bombón");
        }


        public void Borrar(int bombonId, SqlConnection conn, SqlTransaction tran)
        {
            var deleteQuery = @"DELETE FROM Bombones 
                WHERE BombonId=@BombonId";
            int registrosAfectados = conn
                .Execute(deleteQuery, new { @BombonId = bombonId }, tran);
            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo borrar el bombón");
            }

        }

        public void Editar(Bombon bombon, SqlConnection conn, SqlTransaction tran)
        {
            var updateQuery = @"UPDATE Bombones SET 
                        NombreBombon = @Nombre, 
                        Descripcion = @Descripcion, 
                        TipoDeChocolateId = @TipoDeChocolateId, 
                        TipoDeNuezId = @TipoDeNuezId, 
                        TipoDeRellenoId = @TipoDeRellenoId, 
                        PrecioCosto = @PrecioCosto, 
                        PrecioVenta = @PrecioVenta, 
                        Stock = @Stock, 
                        NivelDeReposicion = @NivelDeReposicion, 
                        Imagen = @Imagen, 
                        FabricaId = @FabricaId, 
                        Suspendido = @Suspendido 
                        WHERE BombonId = @ProductoId";

            int registrosAfectados = conn.Execute(updateQuery, new
            {
                bombon.Nombre,
                bombon.Descripcion,
                bombon.TipoDeChocolateId,
                bombon.TipoDeNuezId,
                bombon.TipoDeRellenoId,
                bombon.PrecioCosto,
                bombon.PrecioVenta,
                bombon.Stock,
                bombon.NivelDeReposicion,
                bombon.Imagen,
                bombon.FabricaId,
                bombon.Suspendido,
                bombon.ProductoId // BombonId corresponde a ProductoId en tu clase Bombon
            }, tran);

            if (registrosAfectados == 0)
            {
                throw new Exception("No se pudo editar el bombón");
            }
        }

        public bool EstaRelacionado(int bombonId, SqlConnection conn)
        {
            var selectQuery = @"SELECT COUNT(*) FROM DetallesVentas 
                WHERE BombonId=@BombonId";
            return conn.QuerySingle<int>
                (selectQuery, new { @BombonId = bombonId }) > 0;
        }

        public bool Existe(Bombon bombon, SqlConnection conn)
        {
            var selectQuery = "SELECT COUNT(*) FROM Bombones WHERE NombreBombon = @Nombre";
            if (bombon.ProductoId != 0)
            {
                selectQuery += " AND BombonId<>@ProductoId";
            }
            
            return conn.QuerySingle<int>(selectQuery, bombon) > 0;

        }

        public Bombon? GetBombonPorId(int bombonId, SqlConnection conn)
        {
            string selectQuery = @"SELECT 
                            BombonId AS ProductoId, 
                            NombreBombon AS Nombre, 
                            Descripcion, 
                            TipoDeChocolateId, 
                            TipoDeNuezId, 
                            TipoDeRellenoId, 
                            PrecioCosto, 
                            PrecioVenta, 
                            Stock, 
                            NivelDeReposicion, 
                            Imagen, 
                            FabricaId, 
                            Suspendido 
                          FROM Bombones 
                          WHERE BombonId=@BombonId";

            return conn.QuerySingleOrDefault<Bombon>(selectQuery, new { @BombonId = bombonId });
        }

        public int GetCantidad(SqlConnection conn, TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var listaProductos=new List<ProductoListDto>();
            if (tipoProducto==TipoProducto.Bombon)
            {
                var selectQuery = @"SELECT 
                            BombonId AS ProductoId, 
                            NombreBombon AS Nombre, 
                            Descripcion, 
                            TipoDeChocolateId, 
                            TipoDeNuezId, 
                            TipoDeRellenoId, 
                            PrecioCosto, 
                            PrecioVenta AS Precio, 
                            Stock, 
                            NivelDeReposicion, 
                            Imagen, 
                            FabricaId, 
                            Suspendido FROM Bombones";
                var listaBombones = conn.Query<BombonListDto>(selectQuery).ToList();
                listaProductos.AddRange(listaBombones);

            }
            if (tipoProducto == TipoProducto.Caja)
            {
                var selectQuery = @"SELECT c.CajaId AS ProductoId,
		                        c.NombreCaja AS Nombre,
		                        (SELECT COUNT(*) FROM DetallesCajas dc WHERE dc.cajaId=c.CajaId) AS Variedades,
		                        (SELECT SUM(dc.Cantidad) FROM DetallesCajas dc WHERE dc.CajaId=c.CajaId) as CantidadBombones,
		                        c.PrecioVenta AS Precio,
		                        c.Stock,
		                        c.Suspendido 
                             FROM Cajas c";
                var listaCajas = conn.Query<CajaListDto>(selectQuery).ToList();
                listaProductos.AddRange(listaCajas);

            }

            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Count;
        }


        public List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, TipoProducto tipoProducto, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var listaProductos=new List< ProductoListDto>();

            if (tipoProducto==TipoProducto.Bombon)
            {
                var selectQuery = @"SELECT b.BombonId AS ProductoId, 
                                   b.NombreBombon AS Nombre, 
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
                            INNER JOIN Fabricas f ON b.FabricaId = f.FabricaId
                            ORDER BY b.NombreBombon";
                var listaBombones = conn.Query<BombonListDto>(selectQuery).ToList();
                listaProductos.AddRange(listaBombones);

            }
            if (tipoProducto == TipoProducto.Caja)
            {
                var selectQuery = @"SELECT c.CajaId AS ProductoId,
		                        c.NombreCaja AS Nombre,
		                        (SELECT COUNT(*) FROM DetallesCajas dc WHERE dc.cajaId=c.CajaId) AS Variedades,
		                        (SELECT SUM(dc.Cantidad) FROM DetallesCajas dc WHERE dc.CajaId=c.CajaId) as CantidadBombones,
		                        c.PrecioVenta AS Precio,
		                        c.Stock,
		                        c.Suspendido
                        FROM Cajas c";
                var listaCajas = conn.Query<CajaListDto>(selectQuery).ToList();
                listaProductos.AddRange(listaCajas);

            }
            if (filter != null)
            {
                listaProductos = listaProductos.Where(filter).ToList();
            }
            return listaProductos.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string nombreBombon, int pageSize)
        {
            var positionQuery = @"
                    WITH BombonOrdenado AS (
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY NombreBombon) AS RowNum,
                        NombreBombon
                    FROM 
                        Bombones
                )
                SELECT 
                    RowNum 
                FROM 
                    BombonOrdenado 
                WHERE 
                    NombreBombon = @NombreBombon";

            int position = conn.ExecuteScalar<int>(positionQuery, new { NombreBombon = nombreBombon });
            return (int)Math.Ceiling((decimal)position / pageSize);

        }
    }
}
