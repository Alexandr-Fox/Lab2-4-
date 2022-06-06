using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_v10
{
    public class ListDoc
    {
        private List<Document> _list = new();
        public Document this[int index] 
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
                if (item is Invoice invoice)
                {
                    invoice.Print();
                }
                else if(item is Bill bill)
                {
                    bill.Print();
                }
                else if (item is Receipt receipt)
                {
                    receipt.Print();
                }
            }
        }
        public void AddReceipt()
        {
            Console.Write("Введите дату оплаты: ");
            var date = Console.ReadLine();
            Console.Write("Введите сумму: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("ФИО плательщика: ");
            var person = Console.ReadLine();
            Console.Write("Номер квитанции: ");
            string number = Console.ReadLine();
            _list.Add(new Receipt(person, date, count, number));
            Console.WriteLine("Квитанция добавлена!");
        }
        public void AddBill()
        {
            Console.Write("Введите сумму: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите НДС: ");
            int nds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер счета: ");
            string number = Console.ReadLine();
            _list.Add(new Bill(count, nds, number));
            Console.WriteLine("Счет добавлен!");
        }
        public void AddInvoice()
        {
            Random random = new();
            Console.Write("Введите число товаров: ");
            int count = Convert.ToInt32(Console.ReadLine());
            List<Product> products = new();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите название товара: ");
                string name = Console.ReadLine();
                Console.Write("Введите стоимость товара: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество товара: ");
                int counts = Convert.ToInt32(Console.ReadLine());
                products.Add(new Product(name, price, counts, random.Next(1, 1000000)));
            }
            Console.Write("Введите НДС: ");
            int nds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер накладной: ");
            string number = Console.ReadLine();
            _list.Add(new Invoice(products, nds, number));
            Console.WriteLine("Накладная добавлена!");
        }
        public void Edit()
        {
            Console.Write("Введите номер документа для редактирования: ");
            string number = Console.ReadLine();
            if (_list.Exists(p => p.Number == number)) 
            {
                var item = _list[_list.IndexOf(_list.Find(p => p.Number == number))];
                if (item is Invoice invoice)
                {
                    invoice.Edit();
                }
                else if (item is Bill bill)
                {
                    bill.Edit();
                }
                else if (item is Receipt receipt)
                {
                    receipt.Edit();
                }
            }
            else
                Console.WriteLine("Нет документа с таким номером");
        }
        public void Search()
        {
            Console.Write("Введите номер документа для поиска: ");
            string number = Console.ReadLine();
            if(_list.Exists(p => p.Number == number))
                _list.Find(p => p.Number == number).Print();
            else
                Console.WriteLine( "Нет документа с таким номером");
        }
        public void Delete()
        {
            Console.Write("Введите номер документа для удаления: ");
            string number = Console.ReadLine();
            if (_list.Exists(p => p.Number == number))
            {
                _list.Find(p => p.Number == number).Print();
                Console.Write("Удалить данный элемент? (д/Н)");
                if(Console.ReadLine().ToLower()=="д")
                    _list.Remove(_list.Find(p=>p.Number==number));
                Console.WriteLine("Элемент удален");
            }
            else
                Console.WriteLine("Нет документа с таким номером");
        }
    }
}