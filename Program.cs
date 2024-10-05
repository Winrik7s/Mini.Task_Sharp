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

        static void Enc_Logical_XOR(ref int x, ref int key, out int dec)
        {
            int enc = x ^ key;
            dec = enc ^ key;

            Console.WriteLine("Encrypted number: " + enc);
            Console.WriteLine("Decrypted number: " + dec);
        }

        static void Swap_Logical_XOR(ref int x, ref int y, out int resultA, out int resultB)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

            resultA = x;
            resultB = y;

            Console.WriteLine("Result: " + x);
            Console.WriteLine("Result: " + y);
        }

        static void Logical_N(ref int x, out int result)
        {
            result = ~x;
            Console.WriteLine("Result: " + (result + 1));
        }

        static void Main(string[] wsdctr)
        {
            byte sel;
            int result = 0;

            int result2 = 0;

            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Select: " + 
            "1. Logical multiplication. 2. Logical addition, 3. Enc_Logical_XOR, " +
            "4. Swap_Logical_XOR, 5. Logical_N, ");
            
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
            else if(sel == 3)
            {
                Enc_Logical_XOR(ref a, ref b, out result);
            }
            else if(sel == 4)
            {
                Swap_Logical_XOR(ref a, ref b, out result, out result2);
            }
            else if(sel == 5)
            {
                Logical_N(ref a, out result);
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.ReadLine();
        }
    }
}
