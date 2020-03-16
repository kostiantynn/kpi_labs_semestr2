using System;

namespace Laba3
{
    class MyClass
    {
        public int SumOfElements { get => SumOfMatrixElements(); }
        public int [,] Matrix { get; set; }
        public int NumberOfRows { get; }
        public int NumberOfColumns { get; }

        public MyClass(int NumberOfRows, int NumberOfColumns)
        {
            this.NumberOfRows = NumberOfRows;
            this.NumberOfColumns = NumberOfRows;
            this.Matrix = new int[NumberOfRows, NumberOfColumns];

        }

         private int SumOfMatrixElements()
        {
            int sum = 0;
            foreach (var elem in this.Matrix)
                sum += elem;
            return sum;
        }
        private float CalculateRMSValue(int index)
        {
            double rmsValue = 0.0;
            for(int i = 0; i < this.NumberOfColumns; i++)
                rmsValue += Math.Pow((double)this.Matrix[index, i], 2);
            return (float)Math.Sqrt(rmsValue);
        }
        
        public float this[int index] { get => CalculateRMSValue(index);  }
    }
}
