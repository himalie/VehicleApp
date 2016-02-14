using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleApp.Domain.Context;
using VehicleApp.Domain.Models;
using Serilog;
using Newtonsoft.Json;

namespace VehicleApp.Client.Web.Managers
{
    public class CommentManager : ManagerBase, ICommentManager
    {
        private readonly CarContext _carContext;

        public CommentManager(ILogger logger, CarContext carContext) : base(logger)
        {
            _carContext = carContext;
        }

        public Comment Comment(Comment comment)
        {
            var result = _carContext.Comments.Add(comment);
            _carContext.SaveChanges();

            Logger.Information("Saved Comment Successfully", JsonConvert.SerializeObject(result));
            return result;
        }
    }
}