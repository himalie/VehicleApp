using AutoMapper;
using VehicleApp.Client.Web.ViewModels.Enquiry;
using VehicleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApp.Client.Web.Mapping
{
    public class EnquiryMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            CreateMap<EnquiryViewModel, Enquiry>()
                .ForMember(dest => dest.EnquiryTime, o => o.MapFrom(src => DateTime.Now));
            
            // We don't show Enquiries, let's not map them back to viewmodels then.
        }
    }
}