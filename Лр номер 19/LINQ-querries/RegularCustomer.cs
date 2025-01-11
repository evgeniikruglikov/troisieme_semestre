namespace LINQ_querries
{
    public class RegularCustomer
    {
        public string Name { get; set; }
        public int Discount { get; set; }

        public RegularCustomer(string name, int discount)
        {
            Name = name;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"{Name} со скидкой {Discount}%" ;
        }
    }
}