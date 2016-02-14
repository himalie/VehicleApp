using AutoMapper;
using VehicleApp.Client.Web.ViewModels.Car;
using VehicleApp.Domain.Models;

namespace VehicleApp.Client.Web.Mapping
{
    public class CarMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            CreateMap<Car, CarViewModel>();
            // We don't save cars - let's not map viewmodel to domain model then.
        }
    }
}