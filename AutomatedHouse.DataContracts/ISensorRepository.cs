using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.DataContracts
{
    public interface ISensorRepository : IGenericRepository<Sensor>
    {
        IEnumerable<Sensor> GetSensorsByHouseId(int houseId);
    }
}