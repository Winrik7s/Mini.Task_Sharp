using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static void Logical_M(ref int x, ref int y, out int result)
        {
            result = x & y;
            Console.WriteLine("Result: " + result);
        }

        static void Logical_A(ref int x, ref int y, out int result)
        {
            result = x | y;
            Console.WriteLine("Result: " + result);
        }

        static void Main(string[] wsdctr)
        {
           Console.Write("Enter a: ");
           int a = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter b: ");
           int b = Convert.ToInt32(Console.ReadLine());

           Console.ReadLine();
        }
    }
}
