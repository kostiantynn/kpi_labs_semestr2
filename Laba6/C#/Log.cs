using System;
using System.IO;

namespace laba_6
{
    public class Log
    {
        public void LogAnException(Exception e)
        {
            string fileName = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,"arithmeticExpression.log");

            void WriteToFile(StreamWriter sw)
            {
                sw.Write($"{DateTime.Now}:\t{e}\n\n");
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