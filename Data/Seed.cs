// using System;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// //using TrainChecklist.DomainModels;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore.Internal;
// using TrainChecklist.DomainModels;

// namespace TrainChecklist.Data
// {
//     public static class Seed
//     {
//         public static async Task InsertValuesInDatabase(IServiceProvider serviceProvider, IConfiguration configuration)
//         {
//             var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
//             if (context.Vehicles.Any())
//             {
//                 Console.WriteLine("context.Vehicles.Any = true");
//             }
//             else
//             {
//             Console.WriteLine("context.Vehicles.Any = false");

//             var v1 = Vehicle.Create("Vehicle 1");
//             v1.AddElement("Element 1");
//             v1.AddElement("Element 2");

//             var list = new List<Vehicle>()
//             {
//                 Vehicle.Create("Flirt"),
//                 Vehicle.Create("Pendolino"),
//                 Vehicle.Create("Pospieszny")
//             };
//             list.Add(v1);

//             foreach (Vehicle v in list)
//                 {
//                     context.Vehicles.Add(v);
//                 }
//             context.SaveChanges();
//             }
           
//         }

//     }
// }