using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static void Logical_M(ref int x, ref int y, ref z, out int result)
        {
            result = x & y & z;
            Console.WriteLine("Result: " + result);
        }

        static void Logical_A(ref int x, ref int y, ref int z, out int result)
        {
            result = x | y | z;
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
            result = 0b0000_00000;

            result = result | x;
            result = result << 2;
            
            result = result | y;
            result = result << 2;

            result = result | z;
            Console.WriteLine("Result: " + result);
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

            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Select:");

            Console.WriteLine();

            Console.WriteLine("1. Logical multiplication");
            Console.WriteLine("2. Logical addition");

            Console.WriteLine("3. Enc_Logical_XOR");
            Console.WriteLine("4. Swap_Logical_XOR");

            Console.WriteLine("5. Logical_N");
            Console.WriteLine("6. Shift");

            Console.WriteLine("7. Foo");
            
            Console.WriteLine();

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
            else if(sel == 7)
            {
                Foo(ref a, ref b, ref c, out result);
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.ReadLine();
        }
    }
}
