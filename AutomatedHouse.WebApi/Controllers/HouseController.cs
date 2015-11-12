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
    public class HouseController : ApiController
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        public IEnumerable<House> Get()
        {
            return _houseService.GetAll();
        }

        public House Post(House house)
        {
            return _houseService.Add(house);
        }
    }
}
