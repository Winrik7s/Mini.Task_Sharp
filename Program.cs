using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static double getPi(int n)
        {
            int i = 0;
            int count = 0;

            Random rnd = new Random();

            while(i < n)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();

                if(Math.Pow(x, 2) + Math.Pow(y,2) < 1)
                {
                    count++;
                }

                i++;
            }

            return 4 * ((double)count / n);
        }

        static void Main(string[] wsdctr)
        {
            Console.WriteLine(getPi(1000000));
        }
    }
}
