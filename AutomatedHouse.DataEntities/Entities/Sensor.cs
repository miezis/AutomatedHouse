using System;
using System.Collections.Generic;
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
        public Room Room { get; set; }
    }
}
