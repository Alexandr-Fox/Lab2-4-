using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class Bill:Document
    {
        private int sum;
        private int nds;

        public Bill()
        {
            Random random = new();
            Sum = random.Next(0, 100);
            Nds = random.Next(5, 30);
            Number = $"{random.Next(0,10000)}_B";
        }

        public Bill(int sum, int nds, string number)
        {
            Sum = sum;
            Nds = nds;
            Number = number;
        }

        public int Sum { get => sum; set => sum = value; }
        public int Nds { get => nds; set => nds = value; }
        public new void Print()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Счет №{Number}");
            Console.WriteLine($"Сумма:          {Sum}");
            Console.WriteLine($"НДС:            {Nds}");
            Console.WriteLine($"Итого к оплате: {Sum + (Sum*Nds)/100.0}");
            Console.WriteLine("--------------------------");
        }
        public new void Edit()
        {
            Console.Write("Введите новый номер документа: ");
            Number = Console.ReadLine();
            Console.Write("Введите новый НДС: ");
            Nds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите новую сумму: ");
            Sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Счет изменен");
        }
    }
}