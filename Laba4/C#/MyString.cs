using System;
using System.IO;
using System.Linq;

namespace laba4
{
    public class MyString
    {
        private char[] StrValue { get; set; }

        // Default constructor
        public MyString()
        {
            this.StrValue = null;
        } 
        
        // Constructor with params
        public MyString(params char[] arrOfInteger)
        {
            this.StrValue = arrOfInteger;
        }
        
        // Constructor of copying from another MyString
        public MyString(MyString str)
        {
            this.StrValue = str.StrValue;
        }

        // Getting length of private char field
        public int GetStringLength() => this.StrValue.Length;
        
        // Getting source of private char field
        public void DisplaySource() => Console.WriteLine(this.StrValue);

        // Writing indexer to access elements easily 
        public int this[int index] {
            get => this.StrValue[index];
        }
        
        // Sum of two MyString
        public static MyString operator +(MyString str1, MyString str2)
        {
            int counter = 0;
            var str3 = new MyString();
            str3.StrValue = new char[str1.GetStringLength() + str2.GetStringLength()];
            
            for (int i = 0; i < str1.GetStringLength(); i++)
            {
                str3.StrValue[counter] = str1.StrValue[i];
                counter++;
            }
            for (int i = 0; i < str2.GetStringLength(); i++)
            {
                str3.StrValue[counter] = str2.StrValue[i];
                counter++;
            }
            
            return str3;
        }

        // Subtraction of two MyString objects
        public static MyString operator -(MyString str1, char str2)
        {
            var str3 = new MyString();
            str3.StrValue = new char[str1.GetStringLength()-1];
            int counter = 0;
            if (str1.StrValue.Contains(str2))
            {
                for (int i = 0; i < str1.GetStringLength(); i++)
                {
                    if (str2 == str1.StrValue[i]) {continue;}
                    str3.StrValue[counter] = str1.StrValue[i];
                    counter++;
                }
                
                return str3;
            }
            throw new InvalidDataException($"Char {str2} does not exist in MyString object.");
        }
    }
}