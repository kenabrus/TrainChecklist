using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainChecklist.Data;
using TrainChecklist.DomainModels;
using System.Linq;

namespace TrainChecklist.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {

        private readonly ApplicationDbContext _context;

        public VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Vehicle entity)
        {
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
            // return entity;
        }

        public async Task DeleteAsync(Vehicle entity)
        {
            entity.DeleteAllElements();
            _context.Set<Vehicle>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Vehicle> GetByIdAsync(long id)
            => await _context.Set<Vehicle>().FindAsync(id);

        public async Task<List<Vehicle>> GetAllAsync()
            => await _context.Vehicles.ToListAsync();

        public async Task UpdateAsync(Vehicle entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}