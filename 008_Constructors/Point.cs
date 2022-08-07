using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Constructors
{
    class Point
    {
        private int x, y;
        private string name;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }

        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор с двумя параметрами");
            this.x = x;
            this.y = y;
        }
        public Point(string name) : this(300, 400)
        {
            Console.WriteLine("Пользовательский конструктор с одним параметром");
            this.name = name;
        }
    }
}
