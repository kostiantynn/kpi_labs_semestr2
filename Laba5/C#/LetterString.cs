using System;
using System.Linq;

namespace app
{
    internal class LetterString : BaseString
    {
        internal LetterString(params string[] str) : base(str)
        {
            if (str.All(s => s.All(char.IsLetter)))
            {
                StrValue = str;
            }
            else
            {
                throw new ArgumentException("Your input should contains only letters.");
            }
        }

        public string[] GetWholeValue() => StrValue;

        public string this[int index]
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

        public void AlphabeticSort() =>  Array.Sort(StrValue);

    }
}