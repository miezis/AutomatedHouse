using AutomatedHouse.DataEntities.Enums;

namespace AutomatedHouse.DataEntities.Entities
{
    public class Service : EntityBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int Pin { get; set; }
        public ServiceType Type { get; set; }
        public Status Status { get; set; }
        public Room Room { get; set; }
    }
}
