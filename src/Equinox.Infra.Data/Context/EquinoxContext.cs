﻿using Equinox.Domain.Models;
using Equinox.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Equinox.Infra.Data.Context
{
    public class EquinoxContext : DbContext
    {
		public EquinoxContext(
					  DbContextOptions<EquinoxContext> options) : base(options)
		{
		}

		public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new SysModuleMap());
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // get the configuration from the app settings
        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(_env.ContentRootPath)
        //        .AddJsonFile("appsettings.json")
        //        .Build();
            
        //    // define the database to use
        //    optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));
        //}
    }
}
