namespace Bombones.Entidades.Dtos
{
    public class BombonListDto:ProductoListDto
    {
        public string? TipoDeChocolate { get; set; }
        public string? TipoDeNuez { get; set; }
        public string? TipoDeRelleno { get; set; }
        public string? Fabrica { get; set; }


    }
}
