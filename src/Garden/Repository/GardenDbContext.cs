using Microsoft.EntityFrameworkCore;
using Garden.Models;

namespace Garden.Repository
{
    public class GardenDbContext : DbContext
    {
    
        public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options) { }

        public DbSet<Vegtable> Vegtables { get; set; }
        public DbSet<VegVariety> VegVarieties { get; set; }
        public DbSet<GardenBed> GardenBeds { get; set; }

        //public override void OnModelCreating(ModelBuilder modBuilder)
        //{
        //    base.OnModelCreating(modBuilder);
        //    modBuilder.
        //}
    }
}
