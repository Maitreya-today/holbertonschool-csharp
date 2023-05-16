using System;

public class Number
{
    public static int PrintLastDigit(int num)
    {
        int res = Math.Abs(num % 10);
        Console.Write(res);
        return res;
    }
}
