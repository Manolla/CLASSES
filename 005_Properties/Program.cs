using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Properties
{
    class Constants
    {
        private double pi = 3.14D;
        private double e = 2.71D;
        public double Pi { set { pi = value; } }//свойство только для записи - WriteOnly Property
        public double E { get { return e; } }//св-во только для чтения - ReadOnly Property
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constants constants = new Constants();
            constants.Pi = 3.14159265D;
            //Console.WriteLine(constants.Pi);  //Недопустимо
            //constants.E = 3.17D;              //Недопустимо
            Console.WriteLine("e = {0}", constants.E);
            //Delay
            Console.ReadKey();
        }
    }
}
