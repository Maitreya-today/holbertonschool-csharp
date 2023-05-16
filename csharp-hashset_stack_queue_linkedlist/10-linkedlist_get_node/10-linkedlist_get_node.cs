using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0)
        {
            return 0;
        }

        LinkedListNode<int> currentNode = myLList.First;
        int index = 0;

        while (currentNode != null)
        {
            if (index == n)
            {
                return currentNode.Value;
            }
            currentNode = currentNode.Next;
            index++;
        }

        return 0;
    }
}
