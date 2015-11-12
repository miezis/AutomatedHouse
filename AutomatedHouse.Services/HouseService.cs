using System.Collections.Generic;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.Services
{
    public class HouseService : GenericServiceBase<IHouseRepository, House>, IHouseService
    {
        private readonly IHouseRepository _houseRepository;
        public HouseService(IHouseRepository houseRepository) : base(houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public IEnumerable<House> GetAll()
        {
            return _houseRepository.GetAll();
        }
    }
}
