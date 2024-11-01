using System;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static int Enc(ref int x)
        {
            int key = 24;
            int enc = x ^ key;

            return enc;
        }

        static void Main(string[] wsdctr)
        {
            Account account = new Account();

            Console.Write("Enter the password to log in: ");
            int pass = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(account.Password);
        }
    }
}
