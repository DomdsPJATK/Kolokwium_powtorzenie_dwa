using Kolokwium_2_powtórzenie.Controllers.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kolokwium_2_powtórzenie.Configuration
{
    public class ZamowienieWyrobEfConfiguration : IEntityTypeConfiguration<Zamówienie_WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<Zamówienie_WyrobCukierniczy> builder)
        {
            builder.HasKey(e => e.IdWyrobuCukierniczego);
            builder.HasKey(e => e.IdZamowienia);
            builder.HasOne<Zamowienie>().WithMany().HasForeignKey(e => e.IdZamowienia).IsRequired();
            builder.HasOne<WyrobCukierniczy>().WithMany().HasForeignKey(e => e.IdWyrobuCukierniczego).IsRequired();
            builder.Property(e => e.Uwagi).HasMaxLength(300);
        }
    }
}