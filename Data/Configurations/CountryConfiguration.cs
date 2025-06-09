using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryName).HasMaxLength(100).HasColumnName("Name");
            builder.HasData(
                new Country { Id = 1, CountryName = "United Kingdom", CountryCode = "GB" },
                new Country { Id = 2, CountryName = "France", CountryCode = "FR" },
                new Country { Id = 3, CountryName = "Italy", CountryCode = "IT" }
             );
        }
    }
}
