using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _001_Classes
{
    class Myclass
    {
        public string field;//поле
        public void Method()//метод
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main()
        {
            Myclass instance = new Myclass();
            //Myclass instance = new Myclass() { field = "Hello World!"}; //так красивее и правильнее
            instance.field = "Hello World";
            Console.WriteLine(instance.field);//вывод на экран содержимое поля field
            instance.Method();//вызов метода с именем Method на экземпляре
            Console.ReadKey();
        }
    }
}
