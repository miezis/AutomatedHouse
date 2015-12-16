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
    [RoutePrefix("api/sensors")]
    public class SensorsController : ApiController
    {
        private readonly ISensorService _sensorService;

        public SensorsController(ISensorService sensorService)
        {
            _sensorService = sensorService;
        }

        [Route("{houseId:int}")]
        [HttpGet]
        public IHttpActionResult GetSensorsByHouseId(int houseId)
        {
            var sensors = _sensorService.GetSensorsByHouseId(houseId);

            if (sensors == null)
            {
                return NotFound();
            }
            
            return Ok(sensors);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult Post(Sensor sensor)
        {
            return Ok(_sensorService.Add(sensor));
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult Put(Sensor sensor)
        {
            var sensorToUpdate = _sensorService.GetById(sensor.Id);

            if (sensorToUpdate == null)
            {
                return NotFound();
            }

            sensorToUpdate.Status = sensor.Status;

            _sensorService.Update(sensorToUpdate);

            return Ok(sensorToUpdate);
        }

        [Route("{sensorId:int}")]
        [HttpDelete]
        public IHttpActionResult Delete(int sensorId)
        {
            var sensor = _sensorService.GetById(sensorId);

            if (sensor == null)
            {
                return NotFound();
            }

            _sensorService.Delete(sensor);

            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
