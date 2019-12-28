using System.Collections.Generic;
using System.Threading.Tasks;
using TrainChecklist.DomainModels;
using TrainChecklist.DTO;

namespace TrainChecklist.Services
{
    public interface IVehicleService
    {
        Task<Vehicle> GetById(long id);
        Task<IEnumerable<Vehicle>> GetAllAsync();
        Task AddAsync(VehicleDto entity);
        Task UpdateAsync(long id, VehicleDto entity);
        Task DeleteAsync(long id);
    }
}