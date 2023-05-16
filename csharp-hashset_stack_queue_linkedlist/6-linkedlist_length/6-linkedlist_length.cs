using System;
using System.Collections.Generic;

public class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        LinkedListNode<int> currentNode = myLList.First;

        while (currentNode != null)
        {
            count++;
            currentNode = currentNode.Next;
        }

        return count;
    }
}
