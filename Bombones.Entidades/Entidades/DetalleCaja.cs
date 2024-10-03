namespace Bombones.Entidades.Entidades
{
    public class DetalleCaja
    {
        public int DetalleCajaId { get; set; }
        public int CajaId { get; set; }
        public int BombonId { get; set; }
        public int Cantidad { get; set; }
        //Propiedades de navegación
        public Caja? Caja { get; set; }
        public Bombon? Bombon { get; set; }
    }
}
