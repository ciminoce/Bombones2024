using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        public int GetCantidad(SqlConnection conn, Func<VentaListDto, bool>? filter)
        {
            var selectQuery = @"SELECT
				v.VentaId,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				v.FechaVenta,
				v.Regalo,
				v.Total,
				COALESCE(c.Nombres+' '+c.Apellido,'Consumidor Final') as Cliente
	
				FROM Ventas v LEFT JOIN Clientes c ON v.ClienteId=c.ClienteId
				ORDER BY v.VentaId";
            var listaVentas = conn.Query<VentaListDto>(selectQuery).ToList();
            if (filter is not null)
            {
                listaVentas.Where(filter).ToList();
            }
            return listaVentas.Count;
        }

        public List<VentaListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Func<VentaListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            var listaVentas = new List<VentaListDto>();
            string selectQuery = @"SELECT
				v.VentaId,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				v.FechaVenta,
				v.Regalo,
				v.Total,
				COALESCE(c.Nombres+' '+c.Apellido,'Consumidor Final') as Cliente
	
				FROM Ventas v LEFT JOIN Clientes c ON v.ClienteId=c.ClienteId
				ORDER BY v.VentaId";
            listaVentas = conn.Query<VentaListDto>(selectQuery).ToList();
            if (filter != null)
            {
                listaVentas = listaVentas.Where(filter).ToList();
            }
            return listaVentas.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public Venta? GetVentaPorId(SqlConnection conn, int ventaId, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT
				v.VentaId,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				v.FechaVenta,
				v.Regalo,
				v.Total,
				COALESCE(v.ClienteId,999999) AS ClienteId,
				COALESCE(c.Nombres,'Consumidor') as Nombres,
				COALESCE(c.Apellido,'Final') as Apellido,
				dv.DetalleVentaId,
				dv.VentaId,
				dv.BombonId,
				dv.CajaId,
				dv.Cantidad,
				dv.Precio,
				b.BombonId,
				b.NombreBombon AS Nombre,
				ca.CajaId,
				ca.NombreCaja As Nombre
				FROM Ventas v LEFT JOIN Clientes c ON v.ClienteId=c.ClienteId
				INNER JOIN DetallesVentas dv ON v.VentaId=dv.VentaId
				LEFT JOIN Bombones b ON dv.BombonId=b.BombonId
				LEFT JOIN Cajas ca ON dv.CajaId=ca.CajaId
				WHERE v.VentaId=@VentaId";
			var ventasDictionary=new Dictionary<int, Venta>();
			var resultado = conn.Query<Venta, Cliente, DetalleVenta, Bombon, Caja, Venta>(selectQuery,
				(venta, cliente, detalle, bombon, caja) =>
				{
					if (!ventasDictionary.TryGetValue(venta.VentaId, out var ventaEntry))
					{
						ventaEntry = venta;
						venta.Cliente = cliente;
						venta.Detalles = new List<DetalleVenta>();
						ventasDictionary.Add(venta.VentaId, ventaEntry);
					}
					detalle.Bombon = bombon;
					detalle.Caja = caja;
					ventaEntry.Detalles.Add(detalle);
                    return ventaEntry;

                },
					new { @VentaId = ventaId },
					splitOn: "ClienteId,DetalleVentaId,BombonId,CajaId"
				).FirstOrDefault();
			
			return ventasDictionary.Values.FirstOrDefault();
				
        }
    }
}
