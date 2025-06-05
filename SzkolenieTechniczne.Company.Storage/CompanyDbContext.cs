﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SzkolenieTechniczne.Company.Storage.Entities;

namespace SzkolenieTechniczne.Company.Storage
{
    public class CompanyDbContext :DbContext
    {
        private IConfiguration _configuration { get; }

        public DbSet<Entities.Company> Companies { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<ContactTypeTranslation> ContactTypeTranslations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslation> CountryTranslations { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobPositionTranslation> JobPositionTranslations { get; set; }

        public CompanyDbContext(IConfiguration configuration)
            : base()
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=HP_KACPER;Database=company-dev;Trusted_Connection=True;Encrypt=False;",
            x => x.MigrationsHistoryTable("EFMigrationHistory", "Geo"));
            ;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
