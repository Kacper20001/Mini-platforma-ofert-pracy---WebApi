using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkoeleieTechniczne.Geo.Storage.Entities;

namespace SzkoeleieTechniczne.Geo.Storage
{
    public class GeoDbContext : DbContext
    {
        private IConfiguration _configuration { get; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslation> CountryTranslations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CityTranslation> CityTranslations { get; set; }
        
        public GeoDbContext(IConfiguration configuration) 
            :base()
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=HP_KACPER;Database=geo-dev;Trusted_Connection=True;Encrypt=False;",
            x => x.MigrationsHistoryTable("EFMigrationHistory", "Geo"));
            ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
