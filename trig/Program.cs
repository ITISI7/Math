using System;

namespace trig
{
    class Program
    {
        static double pi = 3.14159265359;
        static double toDegree(double radius)
        {
            return (radius / pi) * 180;
        }
        static double toRadius(double degree)
        {
            return (degree / 180) * pi;
        }
        static void Main(string[] args)
        {
            // 1: 57.295
            // 2: 1.407
            // 6: 21.2
            // 7: 60.61 
            Console.WriteLine();
            
        }
    }
}
