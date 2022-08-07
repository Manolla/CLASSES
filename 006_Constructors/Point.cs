using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Constructors
{
    class Point
    {
        private int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        //конструктор по умолчанию
        public Point()
        {
            Console.WriteLine("Конструктор по умолчанию!");
        }

        //пользовательский конструктор, инициализирует поля
        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор");
            this.x = x;
            this.y = y;
        }
    }
}
