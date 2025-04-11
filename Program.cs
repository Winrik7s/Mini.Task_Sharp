using System;
using System.Text;
using System.Diagnostics;

namespace Mini.Task_Sharp
{
    public class Program
    {
        static string Enc(string str)
        {
            char[] abc = {'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f',
            'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N',
            'n', 'O', 'o', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w',
            'X', 'x', 'Y', 'y', 'Z', 'z'};

            StringBuilder sb = new StringBuilder(str);

            for(int i = 0; i < abc.Length; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {
                    if(str[j] == abc[i])
                    {
                        i += 3;

                        if(i >= abc.Length)
                        i -= abc.Length;

                        sb[j] = abc[i];
                        str = sb.ToString();
                    }
                }
            }

            return str;
        }

        static void Main(string[] wsdctr)
        {
            Console.Write("Enter a message: ");
            string msg = Console.ReadLine();

            Console.WriteLine(Enc(msg));
        }
    }
}
