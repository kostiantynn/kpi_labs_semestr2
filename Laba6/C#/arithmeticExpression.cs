using System;
using System.IO;

namespace laba_6
{
    public class arithmeticExpression
    {
        private double a, c, d;


        public arithmeticExpression(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public double CalculateExpression()
        {
            if (d == 0) 
                throw new DivideByZeroException("You cannot divide by zero. d = 0;");
            if (c + a == 1)
                throw new DivideByZeroException("You cannot divide by zero. Denominator = 0;");
            if (d < 0)
                throw new ArithmeticException("You cannot take sqrt from negative value. d < 0;");
            
            return (2 * c - d * Math.Sqrt(42 / d)) / (c + a - 1);
        }
        
    }
}
