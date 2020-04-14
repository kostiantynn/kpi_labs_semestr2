using System;
using System.Threading.Channels;
using static app.LetterString;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new LetterString("hello", "my", "friend");

            void PrintValues(string[] strings)
            {
                foreach (var str in strings)
                {
                    Console.WriteLine(str);
                }
            }

            PrintValues(str.GetWholeValue());
            str.SortString();
            PrintValues(str.GetWholeValue());
            Console.WriteLine(str.GetLength());
            
        }
    }
}