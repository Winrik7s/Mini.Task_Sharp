public class Account
{
    private int Encryption(int x)
    {
        int key = 24;
        int enc = x ^ key;

        return enc;
    }

    private int password;

    public int Password
    {
        get { return password; }
        set 
        { if(value == Encryption(1569))
            {
              password = value;
            }
            else
            {
                Console.Write("Error! ");
            } 
        }
    }

}