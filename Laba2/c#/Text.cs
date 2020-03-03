using System;
using System.Linq;

namespace Laba2
{
    class Text
    {
        public MyString[] text { get; set; }

        public Text(MyString[] myStrArr)
        {
            this.text = myStrArr;
        }

        public void addStringToText(MyString strToAdd)
        {
            MyString[] newText = new MyString[text.Length + 1];
            for(int i = 0; i < text.Length; i++)
            {
                newText[i] = text[i];
            } newText[text.Length] = strToAdd;
            text = newText;
        }

        public void DeleteStringByIndex(int index)
        {
            MyString[] newText = new MyString[text.Length - 1];
            int j = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (i == index) { continue;}
                newText[j] = text[i];
                j++;
            } text = newText;
        }

        public void ClearText() => text = new MyString[0];

        public MyString getLongestString()
        {
            MyString maxValue = new MyString("");
            for(int i = 0; i < text.Length; i++)
            {
                if (maxValue.Length < text[i].Length) { maxValue = text[i]; }
            }
            return maxValue;
        }

        public int textLength(MyString[] text)
        {
            int counter = 0;
            for(int i = 0; i < text.Length; i++) { counter += text[i].Length; }
            return counter;
        }

        public float getPercentOfDigits()
        {
            char[] digits = "1234567890".ToCharArray();
            float counter = 0;
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < text[i].Length; j++)
                    if (digits.Contains(text[i].Source[j]))
                        counter++;
            return counter / textLength(text);
        }
        public void DisplayText()
        {
            for(int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i].Source);
            }
        }
    }
}
