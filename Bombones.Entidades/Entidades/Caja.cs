namespace Bombones.Entidades.Entidades
{
    public class Caja
    {
        public int CajaId { get; set; }
        public string NombreCaja { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int EnPedido { get; set; }
        public int NivelDeReposicion { get; set; }
        public bool Suspendido { get; set; }
        public List<DetalleCaja> Detalles { get; set; } = new List<DetalleCaja>();
    }
}
