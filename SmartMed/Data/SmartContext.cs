
using Microsoft.EntityFrameworkCore;
using SmartMed.Model;
using SmartMed;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SmartMed.Data
{
    public class SmartContext : DbContext
    {

        public DbSet<TbMedication> TbMedication { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration["SmartMed:Connection"];
                optionsBuilder.UseSqlServer(connectionString);
            }



        }
    }
}
