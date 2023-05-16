using System;

public class HexaDec
{
    public static void Main(string[] args)
    {
        for(int num = 0; num < 99; num++)
        {
            Console.WriteLine("{0} = 0x{1}", num, num.ToString("x"));
        }
    }
}
