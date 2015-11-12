using AutomatedHouse.DataEntities.Enums;

namespace AutomatedHouse.DataEntities.Entities
{
    public class Accessory : EntityBase
    {
        public string Name { get; set; }
        public int Pin { get; set; }
        public AccessoryType Type { get; set; }
        public Status Status { get; set; }
        public Room Room { get; set; }
        public House House { get; set; }
    }
}
