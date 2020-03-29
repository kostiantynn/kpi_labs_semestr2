using System;
using System.Threading.Channels;
using static app.LetterString;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new LetterString("qwertyuiopasdfghjklzxcvbnm");
            Console.WriteLine(str.GetWholeValue());
            str.AlphabeticSort();
            Console.WriteLine(str.GetWholeValue());
            Console.WriteLine(str.GetLength());
        }
    }
}