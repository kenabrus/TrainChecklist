using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Data
{
    public class VehicleTableConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public  void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            // Set configuration for entity
            //builder.ToTable("Student", "UniversityOnionSchema");
            builder.ToTable("Vehicle");

            // Set key for entity
            builder.HasKey(p => p.Id);

            // Set configuration for columns
            //builder
            //    .Property(p => p.ID)
            //    .HasColumnType("int")
            //    .IsRequired();
            //.HasComputedColumnSql("NEXT VALUE FOR [Sequences].[ID]");

            builder.Property(p => p.Name).HasColumnType("nvarchar(64)").IsRequired();

            Console.WriteLine($"VehicleTableConfiguration");
        }
    }
}