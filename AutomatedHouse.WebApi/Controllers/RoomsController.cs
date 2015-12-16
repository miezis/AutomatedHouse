using System.Net;
using System.Web.Http;
using System.Data.Entity;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.WebApi.Controllers
{
    [RoutePrefix("api/rooms")]
    public class RoomsController : ApiController
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [Route("{houseId:int}")]
        public IHttpActionResult GetRoomsByHouseId(int houseId)
        {
            var rooms = _roomService.GetRoomsByHouseId(houseId);

            if (rooms == null)
            {
                return NotFound();
            }
            
            return Ok(rooms);
        }

        [HttpPost]
        public IHttpActionResult Post(Room room)
        {
            return Ok(_roomService.Add(room));
        }

        [HttpPut]
        public IHttpActionResult Put(Room room)
        {
            var roomToUpdate = _roomService.GetById(room.Id);

            if (roomToUpdate == null)
            {
                return NotFound();
            }

            roomToUpdate.Name = room.Name;

            _roomService.Update(roomToUpdate);

            return Ok(roomToUpdate);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int roomId)
        {
            var room = _roomService.GetById(roomId);

            if (room == null)
            {
                return NotFound();
            }

            _roomService.Delete(room);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
