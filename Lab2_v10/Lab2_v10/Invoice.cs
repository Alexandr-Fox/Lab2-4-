using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class Invoice : Bill
    {
        private List<Product> products = new();
        public int Counts { get => products.Count; }
        public Product this[int ind]
        {
            get => ind >= 0 && ind < products.Count ? products[ind] : new Product();
            set
            {
                if (ind >= 0 && ind < products.Count)
                    products[ind] = value;
                else
                    products.Add(value);
            }
        }
        public new int Sum
        {
            get
            {
                int sum = 0;
                foreach (Product product in products)
                    sum += product.Sum * product.Count;
                return sum;
            }
        }
        public Invoice(List<Product> _products, int nds, string number)
        {
            products = _products;
            int sum = 0;
            foreach (Product product in products)
                sum += product.Sum * product.Count;
            Nds = nds;
            Number = number;
        }

        public Invoice()
        {
            Random random = new();
            Nds = random.Next(5,40);
            Number = $"{random.Next(0, 10000)}_I";
            CreateProducts();
        }
        public void CreateProducts()
        {
            Random random = new();
            for (int i = 0; i < random.Next(1,15); i++)
                products.Add(new Product());
        }
        public new void Print()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Накладная №{Number}");
            foreach(Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Общая сумма:    {Sum}");
            Console.WriteLine($"НДС:            {Nds}");
            Console.WriteLine($"Итого:          {Sum + (Sum * Nds) / 100.0}");
            Console.WriteLine("--------------------------");
        }
        public new void Edit()
        {
            Console.Write("Введите новый номер документа: ");
            Number = Console.ReadLine();
            Console.Write("Изменить список товаров? (Д/н) ");
            if (Console.ReadLine().ToLower() != "н")
            {
                Random random = new();
                Console.Write("Введите число товаров: ");
                int count = Convert.ToInt32(Console.ReadLine());
                List<Product> product = new();
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Введите название товара: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите стоимость товара: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество товара: ");
                    int counts = Convert.ToInt32(Console.ReadLine());
                    product.Add(new Product(name, price, counts, random.Next(1, 1000000)));
                }
                products = product;
            }
            Console.Write("Введите НДС: ");
            Nds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Накладная изменена");
        }
    }
}