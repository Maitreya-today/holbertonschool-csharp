using System;

public class Line
{
    public static void PrintLine(int len)
    {
        for(int i = 0; i < len; i++)
            Console.Write("_");
        Console.WriteLine();
    }
}
