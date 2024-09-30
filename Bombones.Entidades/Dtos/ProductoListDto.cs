namespace Bombones.Entidades.Dtos
{
    public class ProductoListDto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Suspendido { get; set; }
    }
}
