namespace Bombones.Entidades.Entidades
{
    public class PermisoRol
    {
        public int PermisoRolId { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public Rol? Rol { get; set; }
        public Permiso? Permiso { get; set; }
    }
}
