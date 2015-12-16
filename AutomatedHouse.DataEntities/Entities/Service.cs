using System.ComponentModel.DataAnnotations.Schema;
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

        public int? RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public int? HouseId { get; set; }

        [ForeignKey("HouseId")]
        public virtual House House { get; set; }
    }
}
