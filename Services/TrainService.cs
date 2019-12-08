using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TrainChecklist.DomainModels;
using TrainChecklist.Repositories;
using TrainChecklist.ViewModels;

namespace TrainChecklist.Services
{
    public class TrainService : ITrainService
    {
        private readonly ITrainRepository _repository;
        private readonly IMapper _mapper;
        public TrainService(ITrainRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TrainViewModel>> GetAll()
        {
           var trains = await _repository.GetAll();
            return _mapper.Map<IEnumerable<Train>, IEnumerable<TrainViewModel>>(trains);
           
        }
    }
}