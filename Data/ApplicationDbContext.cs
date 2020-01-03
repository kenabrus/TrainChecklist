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
        public DbSet<Element> Elements {get; set;}

        public DbSet<Company> Companies {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleTableConfiguration());
            modelBuilder.ApplyConfiguration(new ElementTableConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyTableConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}