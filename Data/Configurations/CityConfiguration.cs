using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(100);
            builder.HasData(
                new City { Id = 1, Name = "London", CountryId = 1 },
                new City { Id = 2, Name = "Paris", CountryId = 2 },
                new City { Id = 3, Name = "Rome", CountryId = 3 }
            );
        }


    }
}
