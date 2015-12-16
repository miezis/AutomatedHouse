using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.DataContracts
{
    public interface IAccessoryRepository : IGenericRepository<Accessory>
    {
        IEnumerable<Accessory> GetAccessoriesByHouseId(int houseId);
    }
}