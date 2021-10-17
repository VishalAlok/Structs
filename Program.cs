using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate point = new Coordinate(10, 20);
            Console.WriteLine(point.x); //output: 10  
            Console.WriteLine(point.y); //output: 20
        }
    }
    struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
