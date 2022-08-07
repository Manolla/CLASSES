using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();//создаём заглоловок
            title.Content = "Contract";
            Body body = new Body();//создаём тело
            body.Content = "Big body of contract...";
            Footer footer = new Footer();//создаём футер
            footer.Content = "Ivanov I.I.";
            Document document = new Document(title, body, footer);//создаём документ и собираем в него заголовок, тело, футер
            document.Show();//выводим докуметн

            //Delay
            Console.ReadKey();
        }
    }
}
