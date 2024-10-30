namespace Bombones.Entidades.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int EnPedido { get; set; }
        public int StockDisponible { get => Stock - EnPedido; }
        public int NivelDeReposicion { get; set; }
        public string? Imagen { get; set; }
        public bool Suspendido { get; set; }
    }

}
