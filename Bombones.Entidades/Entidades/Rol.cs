namespace Bombones.Entidades.Entidades
{
    public class Rol
    {
        public int RolId { get; set; }
        public string? Descripcion { get; set; }
        public List<PermisoRol> Permisos { get; set; }

        public Rol()
        {
            Permisos = new List<PermisoRol>();
        }
    }

}
