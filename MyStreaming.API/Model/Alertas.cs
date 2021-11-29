using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Model
{
    public class Alertas
    {
        [Key]
        public int id { get; set; }
        public int meta_suscriptores { get; set; }
        public bool estatus { get; set; }
        public int num_suscriptores { get; set; }
    }
}
