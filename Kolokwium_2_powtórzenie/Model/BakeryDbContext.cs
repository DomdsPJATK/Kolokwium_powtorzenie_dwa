using Kolokwium_2_powtórzenie.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_2_powtórzenie.Controllers.Model
{
    public class BakeryDbContext : DbContext
    {
        protected BakeryDbContext()
        {
        }

        public BakeryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new KlientEfConfiguration());
            modelBuilder.ApplyConfiguration(new PracownikEfConfiguration());
            modelBuilder.ApplyConfiguration(new WyrobCukierniczyEfConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieEfConfiguration);
            modelBuilder.ApplyConfiguration(new ZamowienieWyrobEfConfiguration);
        }
    }
}