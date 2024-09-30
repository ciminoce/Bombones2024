namespace Bombones.Entidades.Dtos
{
    public class CajaListDto : ProductoListDto
    {
        public int Variedades { get; set; }
        public int CantidadBombones { get; set; }
    }
}
