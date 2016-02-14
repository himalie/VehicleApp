using VehicleApp.Domain.Context;
using VehicleApp.Domain.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace VehicleApp.Domain.Initializer
{
    public class CarContextInitializer : DropCreateDatabaseAlways<CarContext>
    {
        private readonly string TOYOTA = "Toyota";

        protected override void Seed(CarContext context)
        {
            var cars = new List<Car> {
                new Car
                {
                    Make = TOYOTA,
                    Model = "Corolla",
                    Year = 2015,
                    PriceType = CarPriceType.DriveAwayPrice,
                    Price = 23000,
                    Phone = "0445234567",
                    Email = "john.a@abc.com",                    
                    ContactName = "John Den"
                },
                new Car
                {
                    Make = TOYOTA,
                    Model = "Ascent",
                    Year = 2012,
                    PriceType = CarPriceType.ExcludingGovernmentCharges,
                    Price = 21000,
                    Phone = "0443454321",
                    Email = "john.b@abc.com",                    
                    ContactName = "John Ben"
                },
                new Car
                {
                    Make = TOYOTA,
                    Model = "Ascent Hatchback",
                    Year = 2009,
                    PriceType = CarPriceType.PriceOnAsking,
                    Price = 17800,
                    ABN = "ABN-XYZ",
                    Phone = "0443454564",
                    Email = "john.c@abc.com",                    
                    ContactName = "John Cen"
                },
                new Car
                {
                    Make = TOYOTA,
                    Model = "Kluger",
                    Year = 2016,
                    PriceType = CarPriceType.DriveAwayPrice,
                    Price = 37800,
                    ABN = "ABN-CZE",
                    Phone = "0446234823",
                    Email = "john.d@abc.com",                    
                    ContactName = "John Den"
                }
            };

            context.Cars.AddRange(cars);
            base.Seed(context);
        }
        
    }
}
