using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainChecklist.Models;

namespace TrainChecklist.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Console.WriteLine($"ApplicationDbContext");
        }

        
        public DbSet<Projekt> Projekty {get; set;}
        public DbSet<Pojazd> Pojazdy { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Projekt>(entity =>
            {
                entity.ToTable(name: "Projekt");
            });
            builder.Entity<Pojazd>(entity =>
            {
                entity.ToTable(name: "Pojazd");
            });
            builder.Entity<Event>(entity =>
            {
                entity.ToTable(name: "Event");
            });
        }
    }
}
