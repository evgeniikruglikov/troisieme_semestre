using System.Collections.Generic;
using System.Linq;

namespace LINQ_querries
{
    public class Room
    {
        private const int basePrice = 500;
        public List<RoomOption> Options = new List<RoomOption>() { MainForm.GetCommonOption(5) };
        public readonly int Number;
        public int Beds { get; set; }
        public int Rooms { get; set; }
        public int Price => ((basePrice + Options.Sum(op => op.Price)) * Rooms) + basePrice * Beds;
        public bool Booked;

        public Room(int number, int beds = 2, int rooms = 1, List<RoomOption> options = null)
        {
            Number = number;
            Beds = beds;
            Rooms = rooms;
            if (options != null)
                Options = options;
        }

        public override string ToString()
        {
            return $"№{Number}. {Beds}-местный, {Rooms}-комнатный. Цена: {Price}₽. Удобства: " + Options.Select(op => op.Name).Aggregate((n1, n2) => n1 + ", " + n2) + ". " +(Booked ? "Занят" : "Свободен");
        }
    }
}