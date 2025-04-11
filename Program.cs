using System;
using System.Text;

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
            string encMsg;

            for(int i = 0; i < abc.Length; i++)
            {
                for(int j = 0; j < str.Length; j++)
                {
                    if(str[j] == abc[i])
                    {
                        i += 3;

                        StringBuilder sb = new StringBuilder(str);
                        sb[j] = abc[i];
                        str = sb.ToString();
                    }
                }
            }

            encMsg = str;
            return encMsg;
        }

        static void Main(string[] wsdctr)
        {
            
        }
    }
}
