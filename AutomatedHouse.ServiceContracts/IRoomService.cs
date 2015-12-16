using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.ServiceContracts
{
    public interface IRoomService : IGenericServiceBase<Room>
    {
        IEnumerable<Room> GetRoomsByHouseId(int houseId);
    }
}