using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.ServiceContracts
{
    public interface IAccessoryService : IGenericServiceBase<Accessory>
    {
        IEnumerable<Accessory> GetAccessoriesByRoomId(int roomId);
    }
}