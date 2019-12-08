using System.Collections.Generic;
using AutoMapper;
using TrainChecklist.DomainModels;
using TrainChecklist.ViewModels;

namespace TrainChecklist.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            =>  new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Train, TrainViewModel>();
                cfg.CreateMap<IEnumerable<Train>, IEnumerable<TrainViewModel>>();

                // Mapowanie przy zmianie domyślnej nazwy propertisa Vehicle => MyVehicle
                //cfg.CreateMap<Driver, DriverDto>()
                //    .ForMember(x => x.MyVehicle, m => m.MapFrom(p => p.Vehicle));

            })
            .CreateMapper();
        
    }
}