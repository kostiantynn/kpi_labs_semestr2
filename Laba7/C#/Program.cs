using System;
using static Laba7.LinkedList;

namespace Laba7
{
    class Program
    {
        static void Main()
        {
            var linkedlist = new LinkedList();
            linkedlist.Head = new Node(1);
            var node2 = new Node(2);
            linkedlist.Head.Link = node2;
            var node3 = new Node(3);
            node2.Link = node3;
            var node4 = new Node(4);
            node3.Link = node4;
            linkedlist.PrintList();
            Console.WriteLine(linkedlist.FindNumberOfElementsGreaterThanMedian());
            linkedlist.DeleteEvenElements();
            linkedlist.PrintList();
        }
    }
}