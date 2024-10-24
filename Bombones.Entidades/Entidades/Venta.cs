using Bombones.Entidades.Enumeraciones;

namespace Bombones.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public EstadoVenta Estado { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
        public Cliente? Cliente { get; set; }

        public void Agregar(DetalleVenta detalle)
        {
            var dEnVenta=Detalles.FirstOrDefault(
                x=>x.BombonId==detalle.BombonId && x.CajaId==detalle.CajaId);
            if (dEnVenta == null)
            {
                Detalles.Add(detalle);
            }
            else
            {
                dEnVenta.Cantidad += detalle.Cantidad;
            }
        }
        public decimal GetTotal() => Detalles.Sum(dv => dv.Cantidad * dv.Precio);
        public int GetCantidad() => Detalles.Sum(dv => dv.Cantidad);

        public void Borrar(DetalleVenta dt)
        {
            Detalles.Remove(dt);
        }
    }

    
}
