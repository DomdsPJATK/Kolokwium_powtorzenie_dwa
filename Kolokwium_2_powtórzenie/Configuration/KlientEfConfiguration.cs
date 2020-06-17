using Kolokwium_2_powtórzenie.Controllers.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_2_powtórzenie.Configuration
{
    public class KlientEfConfiguration : IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            builder.HasKey(e => e.IdKlient);
            builder.Property(e => e.Imie).HasMaxLength(50);
            builder.Property(e => e.Nazwisko).HasMaxLength(60);
        }
    }
}