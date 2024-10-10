namespace Bombones.Entidades.Dtos
{
    public class VentaListDto
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public string? Cliente { get; set; }

    }
}
