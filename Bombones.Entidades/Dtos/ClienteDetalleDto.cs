using Bombones.Entidades.Entidades;

namespace Bombones.Entidades.Dtos
{
    public class ClienteDetalleDto
    {
        public int ClienteId { get; set; }
        public int Documento { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombres { get; set; } = null!;

        // Relaciones
        public List<DireccionListDto> Direcciones { get; set; } = new List<DireccionListDto>();
        public List<TelefonoListDto> Telefonos { get; set; } = new List<TelefonoListDto>();

    }
}
