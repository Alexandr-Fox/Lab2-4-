using System;

namespace Laba2
{
    class Program
    {
        private static ListDoc listDoc = new ListDoc();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1) Добавить элемент");
                Console.WriteLine("2) Вывести на экран");
                Console.WriteLine("3) Отредактировать элемент");
                Console.WriteLine("4) Удалить элемент");
                Console.WriteLine("5) Найти элемент");
                Console.WriteLine("0) Выход");
                Console.Write("Выбирите действие: ");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                switch (d)
                {
                    case 1:
                        {
                            listDoc.Add();
                            break;
                        }
                    case 2:
                        {
                            listDoc.Print();
                            break;
                        }
                    case 3:
                        {
                            listDoc.Edit();
                            break;
                        }
                    case 4:
                        {
                            listDoc.Delete();
                            break;
                        }
                    case 5:
                        {
                            listDoc.Search();
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
