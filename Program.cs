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

        static void Logical_N(ref int x, ref int y, out int resultA, out int resultB)
        {
            resultA = ~x;
            resultB = ~y;

            Console.WriteLine("Result: " + (resultA + 1));
            Console.WriteLine("Result: " + (resultB + 1));
        }

        static void Shift(ref int x, ref int y, out int result)
        {
            result = x >> y;
            Console.WriteLine("Result right: " + result);

            result = x << y;
            Console.WriteLine("Result left: " + result);
        }

        static void Foo(ref int x, ref int y, ref int z, out int result)
        {
            int value1 = 3;
            int value2 = 2;
            
            int value3 = 1;
            int result = 0b0000_00000;

            result = result | value1;
            result = result << 2;
            
            result = result | value2;
            result = result << 2;

            result = result | value3;
            return result;
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

            Console.WriteLine("Enter c: ");
            int c = Cnvert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Select: " + 
            "1. Logical multiplication. 2. Logical addition, 3. Enc_Logical_XOR, " +
            "4. Swap_Logical_XOR, 5. Logical_N, 6. Shift.");
            
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
                Logical_N(ref a, ref b, out result, out result2);
            }
            else if(sel == 6)
            {
                Shift(ref a, ref b, out result);
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.WriteLine("Result: " + Foo());

            Console.ReadLine();
        }
    }
}
