using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace yash.Data.EF
{
    public class YashDbContextFactory : IDesignTimeDbContextFactory<YashDbContext>
    {
        public YashDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("YashDb");

            var optionsBuilder = new DbContextOptionsBuilder<YashDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new YashDbContext(optionsBuilder.Options);
        }


    }
}