using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static double Foo(int n)
        {
            int i = 0;
            int c = 0;

            Random rnd = new Random();

            while(i < n)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();

                if(Math.Pow(x,2) + Math.Pow(y,2) <= 1)
                {
                    c++;
                }

                i++;
            }

            return (double)c;
        }

        static void Main(string[] wsdctr)
        {
            Console.WriteLine("Кол - во попаданий: " + Foo(10));
        }
    }
}
