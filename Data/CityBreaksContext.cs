using CityBreaks.Web.Data.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using CityBreaks.Web.Models;
using PropertyModel = CityBreaks.Web.Models.Property;
using PropertyConfiguration = CityBreaks.Web.Data.Configurations.PropertyConfiguration;

namespace CityBreaks.Web.Data
{
    public class CityBreaksContext : DbContext
    {
       
            public CityBreaksContext(DbContextOptions<CityBreaksContext> options) : base(options) { }

            public DbSet<Country> Countries { get; set; }
            public DbSet<City> Cities { get; set; }
            public DbSet<PropertyModel> Properties { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new CountryConfiguration());
                modelBuilder.ApplyConfiguration(new CityConfiguration());
                modelBuilder.ApplyConfiguration(new PropertyConfiguration());
            }

    }
}
