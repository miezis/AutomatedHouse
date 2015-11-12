using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;
using NLog;

namespace AutomatedHouse.WebApi.Controllers
{
    public class HouseController : ApiController
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        public IHttpActionResult Get()
        {
            var logger = LogManager.GetLogger("Naujas");
            logger.Info("Got a get request");
            
            return Ok(_houseService.GetAll());
        }

        public IHttpActionResult Post(House house)
        {
            return Ok(_houseService.Add(house));
        }

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
