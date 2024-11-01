using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        /*static void Enc_Logical_XOR(ref int x, ref int key, out int dec)
        {
            int enc = x ^ key;
            dec = enc ^ key;

            Console.WriteLine("Encrypted number: " + enc);
            Console.WriteLine("Decrypted number: " + dec);
        }
        */

        static void Main(string[] wsdctr)
        {
            Account account = new Account();
            account.Password = 5768;

            Console.WriteLine(account.Password);
        }
    }
}
