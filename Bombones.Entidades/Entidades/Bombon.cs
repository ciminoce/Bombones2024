namespace Bombones.Entidades.Entidades
{
    public class Bombon : Producto
    {
        // Otros atributos específicos de Bombon
        public int TipoDeChocolateId { get; set; }
        public int TipoDeNuezId { get; set; }
        public int TipoDeRellenoId { get; set; }
        public int FabricaId { get; set; }
        // Propiedades de navegación
        public TipoDeChocolate? TipoDeChocolate { get; set; }
        public TipoDeNuez? TipoDeNuez { get; set; }
        public TipoDeRelleno? TipoDeRelleno { get; set; }
        public Fabrica? Fabrica { get; set; }
    }

}
