using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using VehicleApp.Client.Web.Managers;
using VehicleApp.Client.Web.ViewModels.Comment;
using VehicleApp.Domain.Models;
using Newtonsoft.Json;
using Serilog;

namespace VehicleApp.Client.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentManager _commentManager;
        private readonly ICarManager _carManager;
        private readonly ILogger _logger;

        public CommentController(
            ICommentManager commentManager,
            ICarManager carManager,
            ILogger logger)
        {
            _commentManager = commentManager;
            _carManager = carManager;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult Comment(CommentViewModel commentInfo)
        {
            _logger.Information("Starting to comment with {0}", JsonConvert.SerializeObject(commentInfo));
            if (ModelState.IsValid && _carManager.FindById(commentInfo.CarId) != null)
            {
                var comment = Mapper.Map<Comment>(commentInfo);//<Comment>(commentInfo);
                _commentManager.Comment(comment);

                _logger.Information("Commenting successful: comment {0}", JsonConvert.SerializeObject(comment));
                return View("Success");
            }
            else
            {
                _logger.Error("Commenting failed with invalid comment input {0}", JsonConvert.SerializeObject(commentInfo));
                return View("Failed");
            }
        }
    }
}