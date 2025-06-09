using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyModel = CityBreaks.Web.Models.Property;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<PropertyModel>
    {
        public void Configure(EntityTypeBuilder<PropertyModel> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.PricePerNight).HasColumnType("decimal(10,2)");
            builder.HasData(
                new PropertyModel { Id = 1, Name = "London Bridge Hotel", PricePerNight = 120, CityId = 1 },
                new PropertyModel { Id = 2, Name = "Eiffel Tower View", PricePerNight = 150, CityId = 2 },
                new PropertyModel { Id = 3, Name = "Colosseum B&B", PricePerNight = 100, CityId = 3 }
            );
        }
    }
}
