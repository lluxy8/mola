using Microsoft.EntityFrameworkCore;

namespace mola.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Restoran> Restorans { get; set; }
        public DbSet<RestoranResim> RestoranResims { get; set; }
        public DbSet<Spa> Spas { get; set; }
        public DbSet<SpaResim> SpaResims { get; set; }
        public DbSet<Etkinlik> Etkinliks { get; set; }
        public DbSet<EtkinlikResim> Etkinliksesims { get; set; }

    }
}
