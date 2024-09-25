namespace Bombones.Entidades.Entidades
{
    public class Caja : Producto
    {
        public List<DetalleCaja> Detalles { get; set; } = new List<DetalleCaja>();
    }
}
