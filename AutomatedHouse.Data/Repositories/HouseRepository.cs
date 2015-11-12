using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Data.Repositories
{
    public class HouseRepository : GenericRepositoryBase<House>, IHouseRepository
    {
        public HouseRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<House> GetAll()
        {
            return DbContext.Set<House>();
        }
    }
}
