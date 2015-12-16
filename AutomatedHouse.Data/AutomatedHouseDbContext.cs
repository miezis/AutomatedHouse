using AutomatedHouse.DataEntities.Entities;
using System.Data.Entity;

namespace AutomatedHouse.Data
{
    public class AutomatedHouseDbContext : DbContext
    {
        public AutomatedHouseDbContext()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Service> Services { get; set; }
        
    }
}
