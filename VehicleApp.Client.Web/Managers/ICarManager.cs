using VehicleApp.Domain.Models;
using System.Collections.Generic;

namespace VehicleApp.Client.Web.Managers
{
    public interface ICarManager
    {
        IList<Car> FindAll();
        Car FindById(int id);
    }
}
