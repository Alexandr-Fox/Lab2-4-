using System;

namespace Laba2
{
    class Milk : Product
    {
        private string _name;

        public string Name => _name;

        public Milk(string shop, double quantity, double price, double expiration, string name)
            : base(shop, quantity, price, expiration)
        {
            _name = name;
        }

        public Milk()
            : base()
        {
            _name = "None";
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Название: {Name}\n" );
        }

        public new void Edit()
        {
            Console.Write("Введите новый магазин: ");
            Shop = Console.ReadLine();
            Console.Write("Введите новое количество: ");
            Quantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новую цену: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новый срок годности: ");
            Expiration = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новое название: ");
            _name = Console.ReadLine();
            Console.WriteLine("\n");
        }
    }
}
