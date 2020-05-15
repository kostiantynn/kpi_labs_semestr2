namespace Laba8
{
    public class Task
    {
        public delegate int LineOperator(string str);

        public static int GetNumberOfDigitsInString(string str)
        {
            int i = 0;
            foreach (var symbvol in str)
                if(char.IsDigit(symbvol)) { i += 1;}

            return i;
        }
    }
}