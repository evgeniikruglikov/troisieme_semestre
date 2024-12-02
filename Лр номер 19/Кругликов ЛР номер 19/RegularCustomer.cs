namespace LINQ_querries
{
    class RegularCustomer
    {
        public readonly string Name;
        public int Discount { get; private set; }

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