using BETARJETA_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BETARJETA_2
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCredito { get; set;}
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options) {
        }

    }
}
