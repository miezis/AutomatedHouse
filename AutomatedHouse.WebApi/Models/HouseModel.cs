using System.Collections.Generic;
using AutomatedHouse.DataEntities.Enums;

namespace AutomatedHouse.WebApi.Models
{
    public class HouseModel
    {
        public List<RoomModel> rooms;
    }

    public class RoomModel
    {
        public List<AccessoryModel> accessories;
    }

    public class AccessoryModel
    {
        public string name { get; set; }
        public int pin { get; set; }
        public Status status { get; set; }
    }
}