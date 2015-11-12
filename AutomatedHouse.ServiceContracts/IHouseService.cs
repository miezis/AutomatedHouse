using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.ServiceContracts
{
    public interface IHouseService : IGenericServiceBase<House>
    {
        IEnumerable<House> GetAll();
    }
}
