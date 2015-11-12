namespace AutomatedHouse.DataEntities.Entities
{
    public class Room : EntityBase
    {
        public string Name { get; set; }
        public House House { get; set; }
    }
}
