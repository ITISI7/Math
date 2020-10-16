using System;
using System.Numerics;

namespace magnitude
{
    class Program
    {
        public float x;
        public float y;
        public float z;
        public float magnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }
        public float Distance(Vector3 other)
        {
            float diffx = x - other.X;
            float diffy = y - other.Y;
            float diffz = z - other.Z;
            return (float)Math.Sqrt(diffx * diffx + diffy * diffy + diffz * diffz);
        }
        static void Main(string[] args)
        {
           
        }
    }
}
