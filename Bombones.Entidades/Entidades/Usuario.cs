﻿namespace Bombones.Entidades.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Clave { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }

        public Rol Rol { get; set; }

    }

}
