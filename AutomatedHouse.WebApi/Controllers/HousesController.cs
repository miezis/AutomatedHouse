using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Autofac;
using Autofac.Core;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;
using AutomatedHouse.WebApi.Models;
using NLog;

namespace AutomatedHouse.WebApi.Controllers
{
    [System.Web.Http.RoutePrefix("api/houses")]
    public class HousesController : ApiController
    {
        private readonly IHouseService _houseService;
        private readonly IRoomService _roomService;
        private readonly IAccessoryService _accessoryService;

        public HousesController(IHouseService houseService, IRoomService roomService, IAccessoryService accessoryService)
        {
            _houseService = houseService;
            _roomService = roomService;
            _accessoryService = accessoryService;
        }

        [System.Web.Http.Route("")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_houseService.GetAll());
        }

        [System.Web.Http.Route("{houseId:int}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetById(int houseId)
        {
            var house = _houseService.GetById(houseId);

            if (house == null)
            {
                return NotFound();
            }

            return Ok(house);
        }

        [System.Web.Http.Route("info/{houseId:int}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetHouseInfoById(int houseId)
        {
            var rooms = _roomService.GetRoomsByHouseId(houseId).ToList();
            var accessories = _accessoryService.GetAccessoriesByHouseId(houseId).ToList();

            var result = new HouseModel {id = houseId, rooms = new List<RoomModel>()};


            foreach (var room in rooms)
            {
                var roomModel = new RoomModel();
                var belongingAccessories = accessories.Where(u => u.RoomId == room.Id).ToList();

                roomModel.accessories = new List<AccessoryModel>();

                foreach (var accessory in belongingAccessories)
                {
                    var accessoryModel = new AccessoryModel
                    {
                        name = accessory.Name,
                        pin = accessory.Pin,
                        status = accessory.Status
                    };


                    roomModel.accessories.Add(accessoryModel);
                }

                result.rooms.Add(roomModel);
            }

            return Ok(result);
        }
        
        [System.Web.Http.Route("")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(House house)
        {
            return Ok(_houseService.Add(house));
        }
        
        [System.Web.Http.Route("")]
        [System.Web.Http.HttpPut]
        public IHttpActionResult Put(House house)
        {
            var houseToUpdate = _houseService.GetById(house.Id);

            if (houseToUpdate == null)
            {
                return NotFound();
            }

            houseToUpdate.Name = house.Name;
            houseToUpdate.ApiKey = house.ApiKey;

            _houseService.Update(houseToUpdate);

            return Ok(houseToUpdate);
        }
        
        [System.Web.Http.Route("{id:int}")]
        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var house = _houseService.GetById(id);
            if (house == null)
            {
                return NotFound();
            }

            _houseService.Delete(house);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
