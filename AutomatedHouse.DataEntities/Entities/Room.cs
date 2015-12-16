using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace AutomatedHouse.DataEntities.Entities
{
    public class Room : EntityBase
    {
        public string Name { get; set; }

        public int? HouseId { get; set; }

        [ForeignKey("HouseId")]
        public virtual House House { get; set; }
    }
}
