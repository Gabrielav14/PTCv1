using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string NombreUsuario;
        private string CorreoElectronico;
        private string Contraseña;
        private int id_Rol;

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombreUsuario, string correoElectronico)
        {
            this.idUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            CorreoElectronico = correoElectronico;
        }

        public Usuario(int idUsuario, string nombreUsuario, string correoElectronico, string contraseña, int id_Rol) : this(idUsuario, nombreUsuario, correoElectronico)
        {
            Contraseña = contraseña;
            this.id_Rol = id_Rol;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string CorreoElectronico1 { get => CorreoElectronico; set => CorreoElectronico = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
    }
}
