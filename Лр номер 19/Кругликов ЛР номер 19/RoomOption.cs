namespace LINQ_querries
{
    public class RoomOption
    {
        public readonly string Name;
        public int Price { get; private set; }

        public RoomOption(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} за {Price}₽";
        }
    }
}