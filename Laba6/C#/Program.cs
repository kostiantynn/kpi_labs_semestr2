using System;
using System.IO;


namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var expr = new arithmeticExpression(0.5, 0.5, -2);
            Console.WriteLine(expr.CalculateExpression());
        }
    }
}