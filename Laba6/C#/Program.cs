using System;


namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            var expr = new arithmeticExpression(0.5, 0.5, -2);
            try
            {
                Console.WriteLine(expr.CalculateExpression());
            }
            catch (Exception e)
            {
                log.LogAnException(e);
            }
        }
    }
}