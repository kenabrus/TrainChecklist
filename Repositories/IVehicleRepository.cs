using System.Collections.Generic;
using System.Threading.Tasks;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetById(long id);
        Task<List<Vehicle>> GetAllAsync();
        Task<Vehicle> Add(Vehicle entity);
        Task Update(Vehicle entity);
        Task Delete(Vehicle entity);
    }
}