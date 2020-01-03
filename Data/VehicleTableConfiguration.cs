using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Data
{
    public class VehicleTableConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public  void Configure(EntityTypeBuilder<Vehicle> b)
        {
            // Set configuration for entity
            //builder.ToTable("Student", "UniversityOnionSchema");
            b.ToTable("Vehicle");

            // Set key for entity
            // b.HasKey(p => p.Id);

            // Set configuration for columns
            //builder
            //    .Property(p => p.ID)
            //    .HasColumnType("int")
            //    .IsRequired();
            //.HasComputedColumnSql("NEXT VALUE FOR [Sequences].[ID]");

            b.Property(p => p.Name).HasColumnType("nvarchar(64)").IsRequired();

            Console.WriteLine($"VehicleTableConfiguration");
        }
    }
}