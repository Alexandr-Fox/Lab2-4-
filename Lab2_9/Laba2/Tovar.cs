using System;

namespace Laba2
{
    class Tovar
    {
        private string _shop;
        private double _quantity;
        private double _price;

        public string Shop
        {
            get => _shop;
            protected set => _shop = value;
        }

        protected double Quantity
        {
            get => _quantity;
            set 
            {
                if (value >= 0) _quantity = value;
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                    _quantity = 1;
                }
            }
        }

        public double Price
        {
            get => _price;
            protected set
            {
                if (value >= 0) _price = value;
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                    _price = 1;
                }
            }
        }

        public Tovar(string shop, double quantity, double price)
        {
            _shop = shop;
            _quantity = quantity;
            _price = price;
        }

        public Tovar()
        {
            _shop = "None";
            _quantity = 0;
            _price = 0;
        }
        public void Print()
        {
            Console.WriteLine($"Магазин: {Shop}" );
            Console.WriteLine($"Количество: {Quantity}" );
            Console.WriteLine($"Цена: {Price}");
        }
    }
}
