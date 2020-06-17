using Kolokwium_2_powtórzenie.Controllers.Model;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_2_powtórzenie.Configuration
{
    public class PracownikEfConfiguration : IEntityTypeConfiguration<Pracownik>
    {
        public void Configure(EntityTypeBuilder<Pracownik> builder)
        {
            builder.HasKey(e => e.IdPracownik);
            builder.Property(e => e.Imie).HasMaxLength(50);
            builder.Property(e => e.Nazwisko).HasMaxLength(60);
        }
    }
}