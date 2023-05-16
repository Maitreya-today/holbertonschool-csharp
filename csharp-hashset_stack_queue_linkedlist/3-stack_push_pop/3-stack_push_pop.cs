using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        bool found = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, found);

        if (found)
        {
            while (aStack.Pop() != search)
                continue;
        }

        aStack.Push(newItem);
        return aStack;
    }
}
