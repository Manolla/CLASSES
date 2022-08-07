using System;


namespace _004_Properties
{
    class MyClass
    {
        private string field = null;
        public string Field
        {
            set
            {
                if(value=="Goodbye")
                {
                    Console.WriteLine("Value not correct. Please tyr later!!!");
                }
                else
                {
                    field = value;
                }
            }
            get
            {
                if(field==null)
                {
                    return "Data is empty!";
                }
                else if(field == "Hello World!")
                {
                    return field.ToUpper();
                }
                else
                {
                    return field;
                }
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.Field = "Goodbye";//Console.WriteLine("Value not correct. Please tyr later!!!"); field = null
            Console.WriteLine(instance.Field);//Data is empty, because field = null
            Console.WriteLine(new string('-', 50));//cw ----------------------
            instance.Field = "Hello World!";//field = Hello World!
            Console.WriteLine(instance.Field); //field.ToUpper()

            Console.ReadKey();
        }
    }
}
