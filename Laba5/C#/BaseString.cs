namespace app
{
    internal class BaseString
    {
        protected string[] StrValue { get; set; }

        internal BaseString(params string[] str)
        {
            StrValue = str;
        }

        public int GetLength() => StrValue.Length;
    }
}