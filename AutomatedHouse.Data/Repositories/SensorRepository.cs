using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.Data.Repositories
{
    public class SensorRepository : GenericRepositoryBase<Sensor>, ISensorRepository
    {
        public SensorRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Sensor> GetSensorsByHouseId(int houseId)
        {
            return DbContext.Set<Sensor>().Where(u => u.HouseId == houseId);
        }
    }
}