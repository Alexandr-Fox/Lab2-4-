using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class ListDoc
    {
        private List<Tovar> _list = new List<Tovar>();
        public Tovar this[int index]
        {
            get
            {
                if (index < 0 || index >= _list.Count)
                    return null;
                return _list[index];
            }
        }

        public int Count { get => _list.Count; }
        public void Print()
        {
            foreach (var item in _list)
            {
                switch (item)
                {
                    case Milk milk:
                        milk.Print();
                        break;
                    case Toy toy:
                        toy.Print();
                        break;
                    case Product product:
                        product.Print();
                        break;
                }
            }
        }

        public void Add()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1) Продукт");
            Console.WriteLine("2) Игрушка");
            Console.WriteLine("3) Молоко");
            Console.WriteLine("Выберите что добавить: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название магазина");
            string shop = Console.ReadLine();
            Console.WriteLine("Введите количество упаковок");
            double quantity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену");
            double price = Convert.ToDouble(Console.ReadLine());
            switch (d)
            {
                case 1:
                {
                    Console.WriteLine("Введите срок годности");
                    double expiration = Convert.ToDouble(Console.ReadLine());
                    _list.Add(new Product(shop, quantity, price, expiration));
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Введите название игрушки");
                    string name = Console.ReadLine();
                    _list.Add(new Toy(shop, quantity, price, name));
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Введите название молока");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите срок годности");
                    double expiration = Convert.ToDouble(Console.ReadLine());
                    _list.Add(new Milk(shop, quantity, price, expiration ,name));
                    break;
                }
            }
        }
        public void Edit()
        {
            Console.Write("Введите название магазина и цену для редактирования: ");
            var shop = Console.ReadLine();
            var price = Convert.ToDouble(Console.ReadLine());
            if (_list.Exists(p => p.Shop == shop && p.Price == price))
            {
                var item = _list[_list.IndexOf(_list.Find(p => p.Shop == shop && p.Price == price))];
                switch (item)
                {
                    case Milk milk:
                        milk.Edit();
                        break;
                    case Toy toy:
                        toy.Edit();
                        break;
                    case Product product:
                        product.Edit();
                        break;
                }
            }
            else
                Console.WriteLine("Нет товара с такими данными");
        }

        public void Search()
        {
            Console.Write("Введите название магазина и цену для поиска: ");
            var shop = Console.ReadLine();
            var price = Convert.ToDouble(Console.ReadLine());
            if (_list.Exists(p => p.Shop == shop && p.Price == price))
            {
                var item = _list[_list.IndexOf(_list.Find(p => p.Shop == shop && p.Price == price))];
                switch (item)
                {
                    case Milk milk:
                        milk.Print();
                        break;
                    case Toy toy:
                        toy.Print();
                        break;
                    case Product product:
                        product.Print();
                        break;

                }
            }
            else
                Console.WriteLine("Нет товара с такими данными");
        }

        public void Delete()
        {
            Console.Write("Введите название магазина и цену для удаления: ");
            string shop = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            if (_list.Exists(p => p.Shop == shop && p.Price == price))
            {
                _list.Find(p => p.Shop == shop && p.Price == price).Print();
                Console.Write("Удалить данный элемент? (д/Н)");
                if (Console.ReadLine().ToLower() == "д")
                    _list.Remove(_list.Find(p => p.Shop == shop && p.Price == price));
                Console.WriteLine("Элемент удален");
            }
            else
                Console.WriteLine("Нет товара с такими данными");
        }
    }
}