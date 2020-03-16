using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new MyClass(2, 3) { Matrix = new int[2, 3] { {1, 2, 3 }, {2, 3, 1 } }  };
            Console.WriteLine(matrix[1]);
            Console.WriteLine(matrix.SumOfElements);
        }
    }
}
