using System;
using System.Collections.Generic;


public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());
        bool found = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, found);
        if (found)
        {
            while (aQueue.Dequeue() != search)
                continue;
        }
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
