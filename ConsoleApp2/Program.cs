using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                Console.WriteLine("введите 1 2 или 3");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("введите x");
                int x = int.Parse(Console.ReadLine());
                double a = 0, b = 0, z, y;
                switch (n)
                {
                    case 1: a = -1.2; b = 0.75; break;
                    case 2: a = 0.4; b = 2.4; break;
                    case 3: a = 1.1; b = 6.1; break;
                }
                z = Math.Log((Math.Abs(Math.Tan(b * x))));
                if (x <= a) y = a + (Math.Sin(b * x) + Math.Pow(Math.Cos(x), 2));
                else if (a < x && x <(Math.Log(b))) y = Math.Sqrt(a + b * x) + Math.Sin(z * x);
                else y = Math.Sqrt(Math.Sqrt(0.3 * b + Math.Sqrt(Math.Abs(a - Math.Pow(z, 2) - Math.Cos(x)))));
                Console.WriteLine("y={0:F2}", y);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
