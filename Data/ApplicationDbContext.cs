using Microsoft.EntityFrameworkCore;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Vehicle> Vehicles {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleTableConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}