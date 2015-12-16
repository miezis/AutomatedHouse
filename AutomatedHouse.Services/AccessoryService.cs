using System.Collections.Generic;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.Services
{
    public class AccessoryService :  GenericServiceBase<IAccessoryRepository, Accessory>, IAccessoryService
    {
        private readonly IAccessoryRepository _accessoryRepository;

        public AccessoryService(IAccessoryRepository repository) : base(repository)
        {
            _accessoryRepository = repository;
        }

        public IEnumerable<Accessory> GetAccessoriesByHouseId(int houseId)
        {
            return _accessoryRepository.GetAccessoriesByHouseId(houseId);
        }
    }
}