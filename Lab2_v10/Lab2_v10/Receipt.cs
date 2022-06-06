using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class Receipt:Document
    {
        private string person;
        private string date;
        private int money;

        public Receipt()
        {
            Date = Convert.ToString(DateTime.Now);
            Random random = new();
            Money = random.Next(0, 100);
            Number = $"{random.Next(0, 10000)}_R";
            Person = "AutoPay";
        }

        public Receipt(string person, string date, int money, string number)
        {
            Person = person;
            Date = date;
            Money = money;
            Number = number;
        }

        public string Person { get => person; set => person = value; }
        public string Date { get => date; set => date = value; }
        public int Money { get => money; set => money = value; }
        public new void Print()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Квитанция №{Number}");
            Console.WriteLine($"Оплатил: {Person}");
            Console.WriteLine($"Дата оплаты: {Date}");
            Console.WriteLine($"Сумма: {Money}");
            Console.WriteLine("--------------------");
        }
        public new void Edit()
        {
            Console.Write("Введите дату оплаты: ");
            Date = Console.ReadLine();
            Console.Write("Введите сумму: ");
            Money = Convert.ToInt32(Console.ReadLine());
            Console.Write("ФИО плательщика: ");
            Person = Console.ReadLine();
            Console.Write("Номер квитанции: ");
            Number = Console.ReadLine();
            Console.WriteLine("Квитанция изменена!");
        }
    }
}