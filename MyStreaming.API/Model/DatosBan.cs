using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Model
{
    public class DatoBan
    {
        [Key]
        public int id { get; set; }
        public string nom_tar { get; set; }
        public string num_tar { get; set; }
        public DateTime fech_vencimiento { get; set; }
        public int cod_seguridad { get; set; }

        [ForeignKey("id_usuario")]
        public int id_usuario { get; set; }
        public bool activo { get; set; }
    }
}
