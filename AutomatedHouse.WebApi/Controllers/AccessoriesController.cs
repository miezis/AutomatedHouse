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
    [RoutePrefix("api/accessories")]
    public class AccessoriesController : ApiController
    {
        private readonly IAccessoryService _accessoryService;

        public AccessoriesController(IAccessoryService accessoryService)
        {
            _accessoryService = accessoryService;
        }

        [Route("{houseId:int}")]
        [HttpGet]
        public IHttpActionResult GetAccessoriesByHouseId(int houseId)
        {
            var accessories = _accessoryService.GetAccessoriesByHouseId(houseId);

            if (accessories == null)
            {
                return NotFound();
            }
            
            return Ok(accessories);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(Accessory accessory)
        {
            return Ok(_accessoryService.Add(accessory));
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult Put(Accessory accessory)
        {
            var accessoryToUpdate = _accessoryService.GetById(accessory.Id);

            if (accessoryToUpdate == null)
            {
                return NotFound();
            }

            accessoryToUpdate.Status = accessory.Status;

            _accessoryService.Update(accessoryToUpdate);

            return Ok(accessoryToUpdate);
        }

        [Route("{accessoryId:int}")]
        [HttpDelete]
        public IHttpActionResult Delete(int accessoryId)
        {
            var accessory = _accessoryService.GetById(accessoryId);

            if (accessory == null)
            {
                return NotFound();
            }

            _accessoryService.Delete(accessory);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
