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
            await _repository.AddAsync(vehicle);
        }

        public async Task DeleteAsync(long id)
        {
            var vehicle = await GetByIdAsync(id);
            await _repository.DeleteAsync(vehicle);
        }

        public async Task<Vehicle> GetByIdAsync(long id)
            => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task UpdateAsync(long id, VehicleDto entity)
        {
            var vehicle = await GetByIdAsync(id);
            vehicle.SetName(entity.Name);
            vehicle.SetModifiedAt(DateTime.UtcNow);
            await _repository.UpdateAsync(vehicle);
        }
    }
}