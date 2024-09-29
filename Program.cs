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

        //new function

        static void Main(string[] wsdctr)
        {
            byte sel;
            int result = 0;

            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Select: " + 
            "1. Logical multiplication. 2. Logical addition.");
            
            Console.Write("You: ");
            sel = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine();

            if(sel == 1)
            {
                Logical_M(ref a, ref b, out result);
            }
            else if(sel == 2)
            {
                Logical_A(ref a, ref b, out result);
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.ReadLine();
        }
    }
}
