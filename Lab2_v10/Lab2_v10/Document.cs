using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class Document
    {
        protected string number;
        public Document()
        {
            Random random = new();
            Number = $"{random.Next(0, 10000)}_D";
        }
        public Document(string number)
        {
            Number = number;
        }

        public string Number { get => number; set => number = value; }
        public void Edit()
        {
            Console.Write("Введите новый номер документа: ");
            Number = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Документ №{Number}");
            Console.WriteLine("--------------------");
        }
    }
}