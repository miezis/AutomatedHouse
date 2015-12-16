using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedHouse.DataEntities.Enums;

namespace AutomatedHouse.DataEntities.Entities
{
    public class Sensor : EntityBase
    {
        public string Name { get; set; }
        public int Pin { get; set; }
        public SensorType Type { get; set; }
        public Status Status { get; set; }
        
        public int? RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public int? HouseId { get; set; }

        [ForeignKey("HouseId")]
        public virtual House House { get; set; }
    }
}
