namespace LINQ_querries
{
    public class RoomOption
    {
        public int Id;
        public string Name { get; set; }
        public int Price { get; set; }

        public RoomOption(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} за {Price}₽";
        }
    }
}