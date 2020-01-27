using System;
using System.Collections.Generic;
using System.Text;


public class Kata
{
    public static int getLoopSize(LoopDetector.Node startNode)
    {
        var list = new List<LoopDetector.Node> { startNode }; 
        var currentNode = startNode.next;
        var duplicateFound = false;
        do
        {
            if (list.Contains(currentNode))
                duplicateFound = true;
            else
            {
                list.Add(currentNode);
                currentNode = currentNode.next;
            }        
        } while (!duplicateFound);

        var lengthOfTail = list.Count;
        foreach (var item in list)
        {
            if (item != currentNode)
                lengthOfTail--;
            else
                break;
        }

        return lengthOfTail;
    }
}

public class LoopDetector
{
    public static Node createChain(int tailLength, int loopLength)
    {
        var endOfTailNode = new Node();
        var currentNode = endOfTailNode;
        for (int i = 1; i <= tailLength; i++)
        {
            currentNode.next = new Node();
            currentNode = currentNode.next;
        }

        var firstNodeOfLoop = new Node();
        currentNode.next = firstNodeOfLoop;
        firstNodeOfLoop.next = new Node();
        currentNode = firstNodeOfLoop.next;
        for (int i = 2; i <= loopLength; i++)
        {
            if (i == loopLength)
            {
                currentNode.next = firstNodeOfLoop;
            }
            else
            {
                currentNode.next = new Node();
                currentNode = currentNode.next;
            }
        }
        return endOfTailNode;
    }
    public class Node
    {
        public Node next { get; set; }
    }
}

    
