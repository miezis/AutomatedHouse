using System.Collections.Generic;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.Services
{
    public class SensorService : GenericServiceBase<ISensorRepository, Sensor>, ISensorService
    {
        private readonly ISensorRepository _sensorRepository;

        public SensorService(ISensorRepository repository) : base(repository)
        {
            _sensorRepository = repository;
        }

        public IEnumerable<Sensor> GetSensorsByHouseId(int houseId)
        {
            return _sensorRepository.GetSensorsByHouseId(houseId);
        }
    }
}