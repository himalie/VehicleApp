using AutoMapper;
using VehicleApp.Client.Web.ViewModels.Comment;
using VehicleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApp.Client.Web.Mapping
{
    public class CommentMappingProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();

            CreateMap<CommentViewModel, Comment>();

            // We don't show Comments, let's not map them back to viewmodels then.
        }
    }
}