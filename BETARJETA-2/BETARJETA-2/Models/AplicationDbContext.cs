using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BETARJETA_2.Models
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options) {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=TarjetaCreditoDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }*/

    }
}
