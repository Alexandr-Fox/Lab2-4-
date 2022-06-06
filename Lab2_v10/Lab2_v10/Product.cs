using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class Product
    {
        private string name;
        private int id;
        private int count;
        private int sum;
        Random random = new();
        public Product()
        {
            string[] names =
            {
                "IPhone 5",
                "IPhone 5s",
                "IPhone 6",
                "IPhone 6s",
                "IPhone 7",
                "IPhone 7s",
                "IPhone 7 plus",
                "IPhone 7s plus",
                "IPhone 10",
                "IPhone 10R",
                "IPhone 11",
                "IPhone 12",
                "IPhone 13",
                "IPhone 10 Pro",
                "IPhone 11 Pro"
            };
            Name = names[random.Next(0, 14)];
            Sum = random.Next(10000, 100000);
            Id = random.Next(1, 1000000);
            Count = random.Next(1, 1000);
        }
        public Product(string name, int sum, int count, int id)
        {
            Name=name;
            Sum=sum;
            Id=id;
            Count=count;
        }
        public string Name { get => name; set => name = value; }
        public int Sum { get => sum; set => sum = value; }
        public int Id { get => id; set => id = value; }
        public int Count { get => count; set => count = value; }
        override public string ToString()
        {
            return $"{Name}  -  {Sum}*{Count} = {Sum*Count}";
        }
    }
}