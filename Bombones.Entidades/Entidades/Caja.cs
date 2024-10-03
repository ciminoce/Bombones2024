namespace Bombones.Entidades.Entidades
{
    public class Caja : Producto
    {
        public List<DetalleCaja> Detalles { get; set; }=new List<DetalleCaja>();
        //public Caja()
        //{
        //    Detalles = new List<DetalleCaja>();
        //}
        public void Agregar(DetalleCaja detalle)
        {
            var detalleEnCaja = Detalles
                .FirstOrDefault(d => d.BombonId == detalle.BombonId);
            if (detalleEnCaja is null)
            {
                Detalles.Add(detalle);
            }
            else
            {
                detalleEnCaja.Cantidad += detalle.Cantidad;
            }
        }
        public bool Existe(DetalleCaja detalle)
        {
            return Detalles.Any(d=>d.BombonId==detalle.BombonId);   
        }
    }
}
