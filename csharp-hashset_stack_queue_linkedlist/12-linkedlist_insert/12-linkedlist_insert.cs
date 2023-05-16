using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.Count == 0)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        LinkedListNode<int> currentNode = myLList.First;
        while (currentNode != null)
        {
            if (currentNode.Value >= n)
            {
                myLList.AddBefore(currentNode, newNode);
                return newNode;
            }
            else if (currentNode.Next == null)
            {
                myLList.AddAfter(currentNode, newNode);
                return newNode;
            }
            currentNode = currentNode.Next;
        }

        return null;
    }
}
