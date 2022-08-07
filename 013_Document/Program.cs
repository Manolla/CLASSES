using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//правильный вариант
namespace _013_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Contract");//создаём документ и передаём заголовок
            document.Body = "Body of big contract...";//передаём тело
            document.Footer = "Director: Ivanov I.I.";//передаём футер
            document.Show();//выводим документ

            //Delay
            Console.ReadKey();
        }
    }
}
