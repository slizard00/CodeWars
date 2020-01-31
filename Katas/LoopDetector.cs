using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Kata
{
    //public static int getLoopSize(LoopDetector.Node startNode)
    //{
    //    var hash = new HashSet<LoopDetector.Node> { startNode };

    //    var currentNode = startNode.next;
    //    var duplicateFound = false;
    //    do
    //    {
    //        if (hash.Contains(currentNode))
    //            duplicateFound = true;
    //        else
    //        {
    //            hash.Add(currentNode);
    //            currentNode = currentNode.next;
    //        }
    //    } while (!duplicateFound);


    //    var found = false;
    //    var startOfLoopNode = currentNode;
    //    var loopSize = hash.Count;
    //    currentNode = startNode;
    //    do
    //    {
    //        if (currentNode == startOfLoopNode)
    //            found = true;
    //        else
    //        {
    //            loopSize--;
    //            currentNode = currentNode.next;
    //        }

    //    } while (!found);

    //    return loopSize;
    //}

    public static int getLoopSize22(LoopDetector.Node startNode)
    {
        var hash = new HashSet<LoopDetector.Node> { startNode };
        var currentNode = startNode.next;
        var duplicateFound = false;
        do
        {
            if (hash.Contains(currentNode))
                duplicateFound = true;
            else
            {
                hash.Add(currentNode);
                currentNode = currentNode.next;
            }
        } while (!duplicateFound);


        var found = false;
        var startOfLoopNode = currentNode;
        var loopSize = hash.Count;
        currentNode = startNode;
        do
        {
            if (currentNode == startOfLoopNode)
                found = true;
            else
            {
                loopSize--;
                currentNode = currentNode.next;
            }

        } while (!found);

        return loopSize;
    }


    public static int getLoopSize_dictionary(LoopDetector.Node startNode)
    {
        var dictionary = new Dictionary<LoopDetector.Node, int>();   
        var currentNode = startNode.next;
        var currentIndex = 0;

        do
        {
            if (dictionary.TryGetValue(currentNode, out int index))
                return currentIndex - index;
            else
                dictionary.Add(currentNode, currentIndex++);
            currentNode = currentNode.next;
        } while (true);
    }

    public static int getLoopSize(LoopDetector.Node startNode)
    {
        var conditionalWeakTable = new ConditionalWeakTable<LoopDetector.Node, IndexedNode>();
        var currentNode = startNode.next;
        var currentKey = 0;

        do
        {
            if (conditionalWeakTable.TryGetValue(currentNode, out IndexedNode b))
            {
                return currentKey - b.Index + 1;
            }
            else
            {
                currentKey++;
                conditionalWeakTable.Add(currentNode, new IndexedNode() { Index = currentKey, Node = currentNode });
                currentNode = currentNode.next;
            }
        } while (true);
    }
    public class IndexedNode
    {
        public int Index;
        public LoopDetector.Node Node;
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

    
