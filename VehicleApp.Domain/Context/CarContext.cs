using VehicleApp.Domain.Initializer;
using VehicleApp.Domain.Models;
using System.Data.Entity;

namespace VehicleApp.Domain.Context
{
    public class CarContext : DbContext
    {
        public CarContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<CarContext>(new CarContextInitializer());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
