using System.Collections.Generic;
using System.Threading.Tasks;
using TrainChecklist.DomainModels;
using TrainChecklist.ViewModels;

namespace TrainChecklist.Services
{
    public interface ITrainService
    {
         Task<IEnumerable<TrainViewModel>> GetAll();
    }
}