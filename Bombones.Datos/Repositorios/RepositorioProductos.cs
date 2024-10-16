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
        public void Agregar(Producto producto, SqlConnection conn, SqlTransaction tran)
        {
            if (producto is Bombon bombon)
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
            if(producto is Caja caja)
            {
                var insertQuery = @"INSERT INTO Cajas (NombreCaja, Descripcion, PrecioCosto, PrecioVenta, Stock, 
                        NivelDeReposicion, Imagen, Suspendido) VALUES 
                        (@NombreCaja, @Descripcion,  @PrecioCosto, @PrecioVenta, @Stock, 
                        @NivelDeReposicion, @Imagen, @Suspendido); 
                        SELECT CAST(SCOPE_IDENTITY() as int)";

                int primaryKey = conn.QuerySingle<int>(insertQuery, new
                {
                    NombreCaja = caja.Nombre,
                    Descripcion = caja.Descripcion,
                    PrecioCosto = caja.PrecioCosto,
                    PrecioVenta = caja.PrecioVenta,
                    Stock = caja.Stock,
                    NivelDeReposicion = caja.NivelDeReposicion,
                    Imagen = caja.Imagen,
                    Suspendido = caja.Suspendido
                }, tran);

                if (primaryKey > 0)
                {
                    caja.ProductoId = primaryKey;
                    return;
                }
                throw new Exception("No se pudo agregar la caja");


            }
        }


        public void Borrar(TipoProducto tipoProducto, int productoId, SqlConnection conn, SqlTransaction tran)
        {
            if (tipoProducto is TipoProducto.Bombon)
            {
                var deleteQuery = @"DELETE FROM Bombones 
                WHERE BombonId=@BombonId";
                int registrosAfectados = conn
                    .Execute(deleteQuery, new { @BombonId = productoId }, tran);
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo borrar el bombón");
                }

            }
            else
            {
                var deleteQuery = @"DELETE FROM Cajas 
                    WHERE CajaId=@CajaId";
                int registrosAfectados = conn
                    .Execute(deleteQuery, new { @CajaId = productoId }, tran);
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo borrar la caja");
                }

            }
        }

        public void Editar(Producto producto, SqlConnection conn, SqlTransaction tran)
        {
            if (producto is Bombon bombon)
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
            if (producto is Caja caja)
            {
                var updateQuery = @"UPDATE Cajas SET 
                        NombreCaja = @Nombre, 
                        Descripcion = @Descripcion, 
                        PrecioCosto = @PrecioCosto, 
                        PrecioVenta = @PrecioVenta, 
                        Stock = @Stock, 
                        NivelDeReposicion = @NivelDeReposicion, 
                        Imagen = @Imagen, 
                        Suspendido = @Suspendido 
                        WHERE CajaId = @ProductoId";

                int registrosAfectados = conn.Execute(updateQuery, new
                {
                    caja.Nombre,
                    caja.Descripcion,
                    caja.PrecioCosto,
                    caja.PrecioVenta,
                    caja.Stock,
                    caja.NivelDeReposicion,
                    caja.Imagen,
                    caja.Suspendido,
                    caja.ProductoId // CajaId corresponde a ProductoId en tu clase Bombon
                }, tran);

                if (registrosAfectados == 0)
                {
                    throw new Exception("No se pudo editar la caja");
                }

            }

        }

        public bool EstaRelacionado(TipoProducto tipoProducto, int productoId, SqlConnection conn)
        {
            if (tipoProducto is TipoProducto.Bombon)
            {
                var selectQuery = @"SELECT COUNT(*) FROM DetallesVentas 
                WHERE BombonId=@BombonId";
                return conn.QuerySingle<int>
                    (selectQuery, new { @BombonId = productoId }) > 0;

            }
            else if(tipoProducto is TipoProducto.Caja)
            {
                var selectQuery = @"SELECT COUNT(*) FROM DetallesVentas 
                WHERE CajaId=@CajaId";
                return conn.QuerySingle<int>
                    (selectQuery, new { @CajaId = productoId }) > 0;

            }
            return false;
        }

        public bool Existe(Producto producto, SqlConnection conn)
        {
            if (producto is Bombon bombon)
            {
                var selectQuery = "SELECT COUNT(*) FROM Bombones WHERE NombreBombon = @Nombre";
                if (bombon.ProductoId != 0)
                {
                    selectQuery += " AND BombonId<>@ProductoId";
                }

                return conn.QuerySingle<int>(selectQuery, bombon) > 0;

            }else if(producto is Caja caja)
            {
                var selectQuery = "SELECT COUNT(*) FROM Cajas WHERE NombreCaja = @Nombre";
                if (caja.ProductoId != 0)
                {
                    selectQuery += " AND CajaId<>@ProductoId";
                }

                return conn.QuerySingle<int>(selectQuery, caja) > 0;

            }
            return false;
        }

        public Producto? GetProductoPorId(TipoProducto tipoProducto, int productoId, SqlConnection conn)
        {
            if(tipoProducto is TipoProducto.Bombon)
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

                return conn.QuerySingleOrDefault<Bombon>(selectQuery, new { @BombonId = productoId });

            }else if(tipoProducto is TipoProducto.Caja)
            {
                string selectQuery = @"SELECT 
                           c.CajaId AS ProductoId, 
                           c.NombreCaja AS Nombre, 
                           c.Descripcion, 
                           c.PrecioCosto, 
                           c.PrecioVenta, 
                           c.Stock, 
                           c.NivelDeReposicion, 
                           c.Imagen, 
                           c.Suspendido,
						   dc.DetalleCajaId,
						   dc.CajaId,
						   dc.BombonId,
						   dc.Cantidad,
						   b.BombonId As ProductoId,
						   b.NombreBombon As Nombre
						   FROM Cajas c
						   INNER JOIN DetallesCajas dc ON c.CajaId=dc.CajaId
						   INNER JOIN Bombones b ON b.BombonId=dc.BombonId
						WHERE c.CajaId=@CajaId";
                var cajaDictionary = new Dictionary<int, Caja>();
                var resultado = conn.Query<Caja, DetalleCaja, Bombon, Caja>(
                    selectQuery, (caja, detalle, bombon) =>
                    {
                        if (!cajaDictionary.TryGetValue(caja.ProductoId, out var cajaEntry))
                        {
                            cajaEntry = caja;
                            cajaEntry.Detalles = new List<DetalleCaja>();
                            cajaDictionary.Add(caja.ProductoId, cajaEntry);
                        };
                        detalle.Bombon = bombon;
                        cajaEntry.Detalles.Add(detalle);
                        return cajaEntry;


                    }, new { @CajaId = productoId },
                    splitOn: "DetalleCajaId,ProductoId");
                return cajaDictionary.Values.FirstOrDefault();
            }
            return null;
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

        public int GetPaginaPorRegistro(SqlConnection conn, TipoProducto tipoProducto, string nombre, int pageSize)
        {
            string positionQuery = string.Empty;
            if(tipoProducto is TipoProducto.Bombon)
            {
                positionQuery = @"
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
                        NombreBombon = @Nombre";

            }
            else
            {
                positionQuery = @"
                        WITH CajaOrdenada AS (
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY NombreCaja) AS RowNum,
                            NombreCaja
                        FROM 
                            Cajas
                    )
                    SELECT 
                        RowNum 
                    FROM 
                        CajaOrdenada 
                    WHERE 
                        NombreCaja = @Nombre";


            }

            int position = conn.ExecuteScalar<int>(positionQuery, new { Nombre = nombre });
            return (int)Math.Ceiling((decimal)position / pageSize);

        }

        public List<Producto> GetListaProductos(SqlConnection conn, TipoProducto tipoProducto)
        {
            var listaProductos = new List<Producto>();
            if (tipoProducto is TipoProducto.Bombon)
            {

                var selectQuery = @"SELECT b.BombonId AS ProductoId, 
                                   b.NombreBombon AS Nombre,
                                b.PrecioVenta,
                                b.Stock
                            FROM Bombones b WHERE b.Suspendido=0
                            ORDER BY b.NombreBombon";
                var listaBombones = conn.Query<Bombon>(selectQuery).ToList();
                listaProductos.AddRange(listaBombones);

            }
            if (tipoProducto is TipoProducto.Caja)
            {

                var selectQuery = @"SELECT c.CajaId AS ProductoId, 
                                   c.NombreCaja AS Nombre,
                                c.PrecioVenta,
                                c.Stock
                            FROM Cajas c WHERE c.Suspendido=0
                            ORDER BY c.NombreCaja";
                var listaCajas = conn.Query<Caja>(selectQuery).ToList();
                listaProductos.AddRange(listaCajas);

            }

            return listaProductos;
        }

    }
}
