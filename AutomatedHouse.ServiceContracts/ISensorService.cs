﻿using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.ServiceContracts
{
    public interface ISensorService : IGenericServiceBase<Sensor>
    {
        IEnumerable<Sensor> GetSensorsByHouseId(int houseId);
    }
}