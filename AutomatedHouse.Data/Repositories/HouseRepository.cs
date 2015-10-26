using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Data.Repositories
{
    public class HouseRepository : GenericRepositoryBase<House>, IHouseRepository
    {
        public HouseRepository(AutomatedHouseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
