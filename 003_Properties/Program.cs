using System;
//Использовангие св-тв для доступа к закрытым полям

//св-во интерфейс доступа к полю объекта
//Св-ва в С№ - поля с логичкским блоком, в котором есть ключевые слова set и get и
//являются суррогатом для замены методов доступа к полю
//При обращении к св-ву вызывается определённый метод
namespace _003_Properties
{
    class Program
    {
        class MyClass
        {
            private string field = null;
            public string Field
            {
                set { field = value; }//void SetField(string value)
                get { return field; }//string GetField()
            }
        }
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.Field = "Hello World!";
            Console.WriteLine(instance.Field);
            //Delay
            Console.ReadKey();
        }
    }
}
