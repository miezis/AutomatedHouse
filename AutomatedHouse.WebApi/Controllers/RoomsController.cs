using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.WebApi.Controllers
{
    public class RoomsController : ApiController
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IHttpActionResult Get(int houseId)
        {
            var rooms = _roomService.GetRoomsByHouseId(houseId);

            if (rooms == null)
            {
                return NotFound();
            }
            
            return Ok(rooms);
        }

        public IHttpActionResult Post(Room room)
        {
            return Ok(_roomService.Add(room));
        }

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
