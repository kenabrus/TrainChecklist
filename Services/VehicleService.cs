using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TrainChecklist.DomainModels;
using TrainChecklist.DTO;
using TrainChecklist.Repositories;

namespace TrainChecklist.Services
{
    public class VehicleService : IVehicleService
    {

        private readonly IVehicleRepository _repository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddAsync(VehicleDto entity)
        {
            var vehicle = Vehicle.Create(entity.Name);
            await _repository.Add(vehicle);
        }

        public async Task DeleteAsync(long id)
        {
            var vehicle = await GetById(id);
            await _repository.Delete(vehicle);
        }

        public async Task<Vehicle> GetById(long id)
            => await _repository.GetById(id);

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task UpdateAsync(long id, VehicleDto entity)
        {
            var vehicle = await GetById(id);
            vehicle.SetName(entity.Name);
            vehicle.SetModifiedAt(DateTime.UtcNow);
            await _repository.Update(vehicle);
        }
    }
}