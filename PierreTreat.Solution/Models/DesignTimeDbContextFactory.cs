using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierreTreat.Models
{
  public class PierreTreatContextFactory : IDesignTimeDbContextFactory<PierreTreatContext>
  {

    PierreTreatContext IDesignTimeDbContextFactory<PierreTreatContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierreTreatContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PierreTreatContext(builder.Options);
    }
  }
}