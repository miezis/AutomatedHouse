using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Services
{
    public class HouseService : GenericServiceBase<IHouseRepository, House>, IHouseService
    {
        public HouseService(IHouseRepository houseRepository) : base(houseRepository)
        {
        }
    }
}
