using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Data
{
    public class ElementTableConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> b)
        {
            b.ToTable("Element");
            b.HasKey(e => e.Id);
            b.Property(e => e.Id).ValueGeneratedOnAdd();
            b.Property(p => p.Name).HasColumnType("nvarchar(64)").IsRequired();

            Console.WriteLine($"ElementTableConfiguration");
        }
    }
}