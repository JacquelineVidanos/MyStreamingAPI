using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Model
{
    public class Temporadas
    {
        [Key]
        public int id { get; set; }
        public string nombre_temporada { get; set; }
    }
}
