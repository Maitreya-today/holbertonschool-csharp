using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return;
        }

        LinkedListNode<int> currentNode = myLList.First;
        int currentIndex = 0;
        while (currentNode != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(currentNode);
                break;
            }
            currentNode = currentNode.Next;
            currentIndex++;
        }
    }
}
