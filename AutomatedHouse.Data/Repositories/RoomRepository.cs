using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Data.Repositories
{
    public class RoomRepository : GenericRepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Room> GetRoomsByHouseId(int houseId)
        {
            return DbContext.Set<Room>().Where(u => u.House.Id == houseId).Include(u => u.House);
        }
    }
}