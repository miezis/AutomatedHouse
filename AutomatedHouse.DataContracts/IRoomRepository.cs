using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.DataContracts
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        IEnumerable<Room> GetRoomsByHouseId(int houseId);
    }
}