using System;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            var C1 = new MyString();
            var C2 = new MyString('1', '2', '3', '4', '5');
            C2.DisplaySource();
            var C3 = new MyString(C2);
            C3.DisplaySource();
            
            C2 -= '5';
            C2.DisplaySource();
            
            C1 = C2 + C3;
            C1.DisplaySource();

        }
    }
}