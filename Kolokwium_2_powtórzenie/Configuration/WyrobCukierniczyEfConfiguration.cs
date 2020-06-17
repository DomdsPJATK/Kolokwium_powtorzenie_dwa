using Kolokwium_2_powtórzenie.Controllers.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_2_powtórzenie.Configuration
{
    public class WyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<WyrobCukierniczy> builder)
        {
            builder.HasKey(e => e.IdWyrobuCukierniczego);
            builder.Property(e => e.Nazwa).HasMaxLength(200);
            builder.Property(e => e.Typ).HasMaxLength(40);
        }
    }
}