using System.Collections.Generic;
using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.DataContracts
{
    public interface IHouseRepository : IGenericRepository<House>
    {
        IEnumerable<House> GetAll();
    }
}
