using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainChecklist.DomainModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace TrainChecklist.Data
{
    public static class Seed
    {
        public static async Task CreateTrains(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Trains.Any())
            {
                Console.WriteLine("context.Trains.Any = true");
            }
            else
            {
            Console.WriteLine("context.Trains.Any = false");
            var trainsList = new List<Train>()
            {
                new Train()
                {
                    Name = "Train 1",
                    BeginTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow
                },
                new Train()
                {
                    Name = "Train 2",
                    BeginTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow
                },
                new Train()
                {
                    Name = "Train 3",
                    BeginTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow
                }
            };

            foreach (Train t in trainsList)
                {
                    context.Trains.Add(t);
                }
                context.SaveChanges();
            }
           
        }

    }
}