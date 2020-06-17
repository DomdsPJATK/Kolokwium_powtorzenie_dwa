using Kolokwium_2_powtórzenie.Controllers.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_2_powtórzenie.Configuration
{
    public class ZamowienieEfConfiguration : IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.HasKey(e => e.IdZamowienia);
            builder.Property(e => e.Uwagi).HasMaxLength(300);
        }
    }
}