using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_AutoProperties
{
    public class Author
    {
        public string Name { get; set; }
        public string Book { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                //блок инициализатора
                Name = "Jefery Richter",
                Book = "CLR via C#"
            };
            Author author2 = new Author() 
            {
                //блок инициализатора
                Name = "Steve McConnell",
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            //Delay
            Console.ReadKey();
        }
    }
}
