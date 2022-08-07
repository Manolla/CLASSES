using System;
//Классы
//Использование методов доступа к закрытым полям

namespace _002_Classes
{
    class MyClass
    {
        private string field = null;//закрытое поле field
        //2 метода доступа
        public void SetField(string value)//Метод-Мутатор - mutator(setter)
        {
            field = value;
        }
        public string GetField()//Метод-аксессор - accessor (grtter)
        {
            return field;
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.SetField("Hello World!!!");//mutator
            string @string = instance.GetField();//accessor
            Console.WriteLine(@string);
            //Delay
            Console.ReadKey();
        }
    }
}
