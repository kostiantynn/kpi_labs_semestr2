using System.Linq;

namespace ConsoleApp1
{
    public class Figure
    {
        protected int[] data;

        public Figure(params int[] data)
        {
            this.data = data;
        }

        protected internal virtual double calculateLength()
        {
            return data.Sum();
        }

        protected internal virtual double calculateArea()
        {
            return 0;
        }
    }
}    