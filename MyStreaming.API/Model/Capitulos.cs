using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Model
{
    public class Capitulos
    {
        [Key]
        public int id { get; set; }
        public string url_video { get; set; }
        public string des_video { get; set; }
        public string titulo_video { get; set; }
        public int id_temporada { get; set; }
        //Foreign key for Temporada
        [ForeignKey("id_temporada")]
        public int estatus { get; set; }
    }

    
}
