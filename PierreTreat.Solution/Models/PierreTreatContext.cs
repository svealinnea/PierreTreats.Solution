using Microsoft.EntityFrameworkCore;


namespace PierreTreat.Models
{
  public class PierreTreatContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; } //DBSets are new tables being created. 
    public DbSet<Flavor> Flavors { get; set; }

    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public PierreTreatContext(DbContextOptions options) : base(options) { } 
  }
}