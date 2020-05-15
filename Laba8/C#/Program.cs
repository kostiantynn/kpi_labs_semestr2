using System;

namespace Laba8
{
    class Program
    {
        private static void Main()
        {
            var stack = new Stack<int>();
            stack.Clear += CleanStackHandler;
            stack.Push(10);
            stack.Push(22);
            stack.Push(45);
            stack.Push(93);
            stack.DisplayStack();
            stack.ClearStack();
            //stack.DisplayStack();

            Task.LineOperator numberSearch = Task.GetNumberOfDigitsInString;
            Console.WriteLine($"Number of digits in string: {numberSearch("XAE-12")}");
        }
        private static void CleanStackHandler(StackHandlerArgs handlerArguments)
        {
            Console.WriteLine(handlerArguments.Message);
        }
    }
}
