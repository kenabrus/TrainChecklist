using System.Collections.Generic;
using AutoMapper;
using TrainChecklist.DomainModels;
using TrainChecklist.DTO;
using TrainChecklist.ViewModels;

namespace TrainChecklist.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            =>  new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Vehicle, VehicleDto>();
                cfg.CreateMap<IEnumerable<Vehicle>, IEnumerable<VehicleDto>>();

                // Mapowanie przy zmianie domyślnej nazwy propertisa Vehicle => MyVehicle
                //cfg.CreateMap<Driver, DriverDto>()
                //    .ForMember(x => x.MyVehicle, m => m.MapFrom(p => p.Vehicle));

            })
            .CreateMapper();
        
    }
}