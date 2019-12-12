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
        public DbSet<Train> Trains {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            

            modelBuilder.Entity<Train>(entity =>
            {
                entity.ToTable(name: "Train");
                entity.Property(e => e.BeginTime).HasColumnType("datetime");
                entity.Property(e => e.EndTime).HasColumnType("datetime");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}