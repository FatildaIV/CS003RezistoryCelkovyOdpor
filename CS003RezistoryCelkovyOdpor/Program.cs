using System;

namespace CS003RezistoryCelkovyOdpor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(P(S(5, P(10, 10)), 10));
            Console.ReadKey();
        }
        static float S(float a, float b)
        {
            return a + b;
        }
        static float P(float a, float b)
        {
            return 1 / (1 / a + 1 / b);
        }
    }
}
