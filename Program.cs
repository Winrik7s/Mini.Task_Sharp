using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static void Main(string[] wsdctr)
        {
           Console.Write("Enter a: ");
           int a = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter b: ");
           int b = Convert.ToInt32(Console.ReadLine());

           int result = a & b;
           Console.WriteLine("Result: " + result);

           Console.ReadLine();
        }
    }
}
