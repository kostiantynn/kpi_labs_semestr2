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
            if (d <= 0)
            {
                if (c + a == 1)
                {
                    var divideByZeroException = new DivideByZeroException("You cannot divide by zero. Denominator = 0;");
                    if (d < 0)
                    {
                        var arithmeticException = new ArithmeticException("You cannot take sqrt from negative value. d < 0;");
                        LogAnException(divideByZeroException, arithmeticException);
                    }
                    else if (d == 0)
                        LogAnException(new DivideByZeroException("You cannot divide by zero. Denominator = 0 and d = 0;"));
                    else
                        LogAnException(divideByZeroException);
                }
                else
                {
                    LogAnException(new DivideByZeroException("You cannot divide by zero. d = 0;"));
                    if (d < 0) LogAnException(new ArithmeticException("You cannot take sqrt from negative value. d < 0;"));
                }
                
            }
            else if(c + a == 1)
            {
                LogAnException(new DivideByZeroException("You cannot divide by zero. Denominator = 0;"));
            }
            var solution = (2 * c - d * Math.Sqrt(42 / d)) / (c + a - 1);
            return solution;
        }

        private void LogAnException(params Exception[] e)
        {
            string fileName = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,"log.txt");

            void WriteToFile(StreamWriter sw)
            {
                foreach (var exception in e)
                {
                    sw.Write($"{DateTime.Now}:\t{exception.ToString()}\n");
                }
            }

            if (!File.Exists(fileName))
            {
                using var sw = new StreamWriter(fileName);
                sw.WriteLine($"Created date:{DateTime.Now}\t Logs for: {this.GetType().Name}\n");
                WriteToFile(sw);
            }
            else
            {
                using var sw = File.AppendText(fileName);
                WriteToFile(sw);
            }
        }
    }
}
