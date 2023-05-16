using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Holberton";
        string first3 = word.Substring(0, 3);
        string last2 = word.Substring(word.Length -2);
        string middle = word.Substring(1, word.Length -2);
        Console.WriteLine("First 3 letters: {0}", first3);
        Console.WriteLine("Last 2 letters: {0}", last2);
        Console.WriteLine("Middle word: {0}", middle);
    }
}
