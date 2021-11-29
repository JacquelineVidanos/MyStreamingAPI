using Microsoft.EntityFrameworkCore;
using MyStreaming.API.Model;

namespace MyStreaming.API
{
    public class MyStreamingContext : DbContext
    {
        public MyStreamingContext(DbContextOptions<MyStreamingContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Alertas> alertas { get; set; }
        public DbSet<Capitulos> capitulo { get; set; }
        public DbSet<Temporadas> temporadas { get; set; }
        public DbSet<DatoBan> datos_bancarios { get; set; }
        /*public DbSet<Favoritos> favoritos { get; set; }
        public DbSet<Images> images { get; set; }*/
        public DbSet<Suscripciones> suscripcion { get; set; }

    }
}
