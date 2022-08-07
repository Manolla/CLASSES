using System;


//создание экземпляра по слабой ссылке(Анонимные объекты)

namespace _011_Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello World");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method();//вызов метода по слабой ссылке


            MyClass class1 = new MyClass();
            class1.Method();//вызов метода по сильной ссылке после создания объекта и идентификатора

            //Delay
            Console.ReadKey();
        }
    }
}
