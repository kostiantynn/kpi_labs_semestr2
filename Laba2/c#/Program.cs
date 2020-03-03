using System;
using static Laba2.MyString;
using static Laba2.Text;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            string forText1 = "Hello, my name is Kostya 7998798789";
            string forText2 = "Currently I am studing at KPI";
            string forText3 = "And I am keen on coding, analysing data and absolutely absessed with self develpment.";
            Text text = new Text(new MyString[] { new MyString(forText1), new MyString(forText2), new MyString(forText3)});
            //text.DisplayText();
            MyString strToAdd = new MyString("My hobbies are reading books, sport, and obviously coffee ;)");
            text.addStringToText(strToAdd);
            //text.DisplayText();
            //text.DeleteStringByIndex(2);
            //text.DisplayText();
            //text.ClearText();
            //text.DisplayText();
            MyString maxValue = text.getLongestString();
            Console.WriteLine(maxValue.Source);
            Console.WriteLine(text.textLength(text.text));
            Console.WriteLine(text.getPercentOfDigits());
        }
    }
}
