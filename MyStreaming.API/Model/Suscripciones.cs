using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyStreaming.API.Model
{
    public class Suscripciones
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("id_usuario")]
        public int id_usuario { get; set; }
        public string codigo_suscripcion { get; set; }
        public double monto { get; set; }
        public bool pagado { get; set; }
        public DateTime fecha_suscripcion { get; set; }
        public DateTime fecha_pago { get; set; }
    }
}
