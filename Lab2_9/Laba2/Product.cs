using System;

namespace Laba2
{
    internal class Product : Tovar
    {
        private double _expiration;

        protected double Expiration
        {
            get => _expiration;
            set
            {
                if (value > 0) _expiration = value;
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                    _expiration = 1;
                }
            }
        }
        public Product(string shop, double quantity, double price, double expiration)
            : base(shop, quantity, price)
        {
            _expiration = expiration;
        }

        protected Product()
            : base()
        {
            _expiration = 0;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Срок годности: {Expiration}" );
        }

        public void Edit()
        {
            Console.Write("Введите новый магазин: ");
            Shop = Console.ReadLine();
            Console.Write("Введите новое количество: ");
            Quantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новую цену: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите новый срок годности: ");
            Expiration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
        }
    }
}
