using System.ComponentModel.DataAnnotations;

namespace MyStreaming.API.Model
{
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
        public int tipo_usuario { get; set; }
        public bool estatus { get; set; }
    }
}
