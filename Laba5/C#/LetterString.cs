using System;
using System.Linq;

namespace app
{
    internal class LetterString : BaseString
    {
        private char[] StrValue { get; set; }
        internal LetterString(string str) : base(str)
        {
            if (str.All(char.IsLetter))
            {
                StrValue = str.ToCharArray();
            }
            else
            {
                throw new ArgumentException("Your input should contains only letters.");
            }
        }

        public char[] GetWholeValue() => this.StrValue;

        public char this[int index]
        {
            get
            {
                try
                {
                    return StrValue[index];
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Index out of range.");
                    throw;
                }
            }
        }

        public void AlphabeticSort() =>  Array.Sort<char>(this.StrValue);

    }
}