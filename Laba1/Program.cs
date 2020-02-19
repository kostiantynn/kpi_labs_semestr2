using System;

namespace Laba1 {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Enter two numbers to compare: ");
            Console.WriteLine("Enter a: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EqualityFunction(a, b) ? "Numbers are equal" : "Numbers are not equal");
            Console.WriteLine("Enter number to increment it: ");
            var c = Convert.ToInt32(Console.ReadLine());
            Increment(c, out var res);
            Console.WriteLine(res);
        } 
        private static void Increment(int number, out int result) {
            result = -~number;
        } 
        private static bool EqualityFunction(int number1, int number2) =>
            !Convert.ToBoolean(number1 ^ number2);

    }
}
