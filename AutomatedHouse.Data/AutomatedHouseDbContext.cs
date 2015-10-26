using AutomatedHouse.DataEntities.Entities;
using System.Data.Entity;

namespace AutomatedHouse.Data
{
    public class AutomatedHouseDbContext : DbContext
    {
        public AutomatedHouseDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
