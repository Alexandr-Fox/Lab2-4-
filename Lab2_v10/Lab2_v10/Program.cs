namespace Lab2_v10
{
    public class Program
    {
        //Ростовский Александр Евгеньевич вариант 10 повышеный уровень
        private static ListDoc listDoc = new();
        public static void Main()
        { 
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1) добавить счет");
                Console.WriteLine("2) добавить накладную");
                Console.WriteLine("3) добавить квитанцию");
                Console.WriteLine("4) вывести на экран");
                Console.WriteLine("5) отредактировать элемент");
                Console.WriteLine("6) удалить элемент");
                Console.WriteLine("0) выход");
                Console.Write("Выбирите действие: ");
                int d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        {
                            listDoc.AddBill();
                            break;
                        }
                    case 2:
                        {
                            listDoc.AddInvoice();
                            break;
                        }
                    case 3:
                        {
                            listDoc.AddReceipt();
                            break;
                        }
                    case 4:
                        {
                            listDoc.Print();
                            break;
                        }
                    case 5:
                        {
                            listDoc.Edit();
                            break;
                        }
                    case 6:
                        {
                            listDoc.Delete();
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