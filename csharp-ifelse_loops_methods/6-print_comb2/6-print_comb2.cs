using System;

public class Digits
{
    public static void Main(string[] args)
    {
        for(int dig = 0; dig < 9; dig++)
        {
            for(int j = dig + 1; j < 10; j++)
            {
                Console.Write("{0}{1}{2}", dig, j, dig == 8 ? "\n" : ", ");
            }
            
        }
    }
}
