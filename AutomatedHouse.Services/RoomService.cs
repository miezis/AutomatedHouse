using System.Collections.Generic;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.Services
{
    public class RoomService : GenericServiceBase<IRoomRepository, Room>, IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository repository) : base(repository)
        {
            _roomRepository = repository;
        }

        public IEnumerable<Room> GetRoomsByHouseId(int houseId)
        {
            return _roomRepository.GetRoomsByHouseId(houseId);
        }
    }
}