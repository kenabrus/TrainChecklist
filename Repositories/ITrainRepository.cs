using System.Collections.Generic;
using System.Threading.Tasks;
using TrainChecklist.DomainModels;

namespace TrainChecklist.Repositories
{
    public interface ITrainRepository
    {
        Task<IEnumerable<Train>> GetAll(); 
    }
}