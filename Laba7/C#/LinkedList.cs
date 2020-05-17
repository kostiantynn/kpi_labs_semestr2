using System;

namespace Laba7
{
    public class LinkedList
    {
        public Node Head;
        
        public class Node
        {
            public double Data { get; }
            public Node Link;

            public Node(double data)
            {
                Data = data;
                Link = null;
                
            }
        }

        public int FindNumberOfElementsGreaterThanMedian()
        {
            var count = 0;
            var median = MedianValue();
            var temp = Head;
            while (temp != null)
            {
                if (temp.Data > median)
                {
                    count++;
                }

                temp = temp.Link;
            }

            return count;
        }

        public void DeleteEvenElements()
        {
            var next = Head.Link;
            var after = Head.Link.Link;
            Head = next;
            while (next != null && after != null)
            {
                next.Link = after.Link;
                after = null;
                next = next.Link;
                if (next != null)
                {
                    after = next.Link;
                }
            }
        }

        public void PrintList()
        {
            var temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data+ "->");
                temp = temp.Link;
            }

            Console.WriteLine("null");
        }
        private double MedianValue()
        {
            var sum = 0.0;
            var count = 0;
            var temp = Head;
            while (temp != null)
            {
                sum += temp.Data;
                count++;
                temp = temp.Link;
            }

            return sum / count;
        }
    }
}