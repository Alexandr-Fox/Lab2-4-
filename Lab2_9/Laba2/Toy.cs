using System;

namespace Laba2
{
    class Toy : Tovar
    {
        private string _name;

        public string Name => _name;

        public Toy(string shop, double quantity, double price, string name)
            : base(shop, quantity, price)
        {
            _name = name;
        }

        public Toy()
            : base()
        {
            _name = "None";
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Название: {Name}"  );
            Console.WriteLine("\n");
        }

        public void Edit()
        {
            Console.Write("Введите новый магазин: ");
            Shop = Console.ReadLine();
            Console.Write("Введите новое количество: ");
            Quantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новую цену: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новое название: ");
            _name = Console.ReadLine();
            Console.WriteLine("\n");
        }
    }
}
