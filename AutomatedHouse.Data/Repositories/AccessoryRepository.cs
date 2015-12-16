using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Data.Repositories
{
    public class AccessoryRepository : GenericRepositoryBase<Accessory>, IAccessoryRepository
    {
        public AccessoryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Accessory> GetAccessoriesByHouseId(int houseId)
        {
            return DbContext.Set<Accessory>().Where(u => u.HouseId == houseId);
        }
    }
}