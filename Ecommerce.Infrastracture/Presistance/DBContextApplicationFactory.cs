using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastracture.Presistance
{
    internal class DBContextApplicationFactory : IDesignTimeDbContextFactory<DBContextApplication>
    {
        public DBContextApplication CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<DBContextApplication>();
            optionsBuilder.UseSqlServer(connectionString);

            // Return a new instance of DBContextApplication with the configured options
            return new DBContextApplication(optionsBuilder.Options);
        }
    }
}
