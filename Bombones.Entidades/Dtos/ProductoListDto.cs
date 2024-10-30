namespace Bombones.Entidades.Dtos
{
    public class ProductoListDto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int EnPedido { get; set; }
        public int StockDisponible { get=>Stock-EnPedido; }
        public bool Suspendido { get; set; }
    }
}
