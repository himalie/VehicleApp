using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Domain.Models;

namespace VehicleApp.Client.Web.Managers
{
    public interface ICommentManager
    {
        Comment Comment(Comment comment);
    }
}
