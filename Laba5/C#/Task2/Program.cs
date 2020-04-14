using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elipse elipse = new Elipse(3, 8);
            Console.WriteLine(elipse.calculateLength());
            Console.WriteLine(elipse.calculateArea());
            
            Circle circle = new Circle(5);
            Console.WriteLine(circle.calculateArea());
            Console.WriteLine(circle.calculateLength());
        }
    }
}