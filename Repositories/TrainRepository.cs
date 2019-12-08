using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainChecklist.Data;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Repositories
{
    public class TrainRepository : ITrainRepository
    {
        private readonly ApplicationDbContext _context;

        public TrainRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Train>> GetAll()
        {
            return await _context.Trains.ToListAsync();
        }
    }
}