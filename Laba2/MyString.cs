namespace Laba2
{
    public class MyString
    {
        public char[] Source { get; set; }
        public int Length { get => Source.Length; }

        public MyString(string str)
        {
            this.Source = str.ToCharArray();
        }
    }
}