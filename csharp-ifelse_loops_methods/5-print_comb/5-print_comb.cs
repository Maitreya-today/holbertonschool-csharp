using System;

public class Program
{
    public static void Main(string[] args)
    {
        string output = "";

        for (int number = 0; number < 100; number++)
        {
            if (number < 10)
            {
                output += "0";
            }

            output += number;

            if (number < 99)
            {
                output += ", ";
            }
        }

        Console.Write(output + "\n");
    }
}
