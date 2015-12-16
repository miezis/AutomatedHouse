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
    [RoutePrefix("api/houses")]
    public class HousesController : ApiController
    {
        private readonly IHouseService _houseService;

        public HousesController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_houseService.GetAll());
        }

        [Route("{houseId:int}")]
        [HttpGet]
        public IHttpActionResult GetById(int houseId)
        {
            var house = _houseService.GetById(houseId);

            if (house == null)
            {
                return NotFound();
            }

            return Ok(house);
        }
        
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(House house)
        {
            return Ok(_houseService.Add(house));
        }
        
        [Route("")]
        [HttpPut]
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
        
        [Route("")]
        [HttpDelete]
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
