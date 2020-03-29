namespace app
{
    internal class BaseString
    {
        private char[] StrValue { get; }

        internal BaseString(string str)
        {
            StrValue = str.ToCharArray();
        }

        public int GetLength() => StrValue.Length;
    }
}