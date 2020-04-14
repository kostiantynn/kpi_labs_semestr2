using System.Linq;
using static System.Math;
namespace ConsoleApp1
{
    public class Elipse : Figure
    {
        public Elipse(int axis1, int axis2) : base(axis1, axis2)
        {
            this.data = new[] {axis1, axis2};
        }

        protected internal override double calculateLength() => base.calculateLength() * PI;

        protected internal override double calculateArea() => PI * data.Aggregate((x,y) => x * y);
        
        }
}