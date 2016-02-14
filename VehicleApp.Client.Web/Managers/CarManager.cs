using VehicleApp.Domain.Context;
using VehicleApp.Domain.Models;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace VehicleApp.Client.Web.Managers
{
    public class CarManager : ManagerBase, ICarManager
    {
        private readonly CarContext _carContext;

        public CarManager(CarContext carContext, ILogger logger) : base(logger)
        {
            _carContext = carContext;
        }

        public IList<Car> FindAll()
        {
            return _carContext
                .Cars
                .ToList<Car>();
        }

        public Car FindById(int Id)
        {
            return _carContext
                .Cars
                .Find(Id);
        }
    }
}