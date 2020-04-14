using static System.Math;
namespace ConsoleApp1
{
    public class Circle : Figure
    {
        public Circle(int r) : base(r)
        {
            this.data = new[] {r};
        }

        protected internal override double calculateArea()
        {
            return PI * Pow(data[0], 2);
        }

        protected internal override double calculateLength()
        {
            return 2 * PI * data[0];
        }
    }
}