using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Data
{
    public class CompanyTableConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> b)
        {
            b.ToTable("Company");
            // b.HasKey(e => e.Id);
            // b.Property(e => e.Id).ValueGeneratedOnAdd();

            Console.WriteLine($"CompanyTableConfiguration");
        }
    }
}