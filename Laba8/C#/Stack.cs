using System;

namespace Laba8
{
    public class Stack<T>
    {

        public delegate void StackHandler(StackHandlerArgs handlerArguments);

        public event StackHandler Clear;
        
        private class Node
        {
            public T Data;
            public Node Link;
        }

        private Node _root;

        public Stack()
        {
            _root = null;
        }

        public bool IsEmpty()
        {
            return _root == null;
        }
        public void Push(T x)
        {
            var temp = new Node();
            if (temp == null)
            {
                throw new StackOverflowException("Stack overflow");
            }

            temp.Data = x;
            temp.Link = _root;
            _root = temp;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new UnderflowException("You cannot pop element from empty stack.");
            var data = _root.Data;
            _root.Data = default;
            _root = _root.Link;
            return data;
        }
        public void ClearStack()
        {
            while (!IsEmpty())
                Pop();
            Clear?.Invoke(new StackHandlerArgs("Stack is cleared", this));
        }
        public void DisplayStack()
        {
            if (IsEmpty())
                throw new UnderflowException("You cannot display elements from empty stack.");
            Node temp = _root;
            while (temp != null)
            {
                Console.Write("{0}->", temp.Data);
                temp = temp.Link;
            }
            Console.Write("null\n");
        }
    }
}