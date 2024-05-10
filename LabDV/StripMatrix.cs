using System;

namespace LabDV
{
    public class StripMatrix
    {
        private double[] data;
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        private int lowerStripWidth;
        private int upperStripWidth;
        public int LowerStripWidth { get { return lowerStripWidth; } }
        public int UpperStripWidth { get { return upperStripWidth; } }


        public StripMatrix(int rows, int cols, int lowerStripWidth, int upperStripWidth)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.lowerStripWidth = lowerStripWidth;
            this.upperStripWidth = upperStripWidth;
            this.data = new double[rows * (lowerStripWidth + upperStripWidth + 1)];
        }

        public double this[int i, int j]
        {
            get
            {
                // Обчислюємо індекс елемента в одновимірному масиві
                int index = (j - i + lowerStripWidth) + i * (lowerStripWidth + upperStripWidth + 1);

                // Перевіряємо, чи індекси знаходяться в межах розмірів матриці та діагональних полос
                if (i >= 0 && i < Rows && j >= 0 && j < Cols && Math.Abs(j - i) <= Math.Max(lowerStripWidth, upperStripWidth))
                    // Якщо умови виконуються, повертаємо значення елемента матриці за вказаними індексами
                    return data[index];
                else
                    // В іншому випадку повертаємо 0
                    return 0;
            }
            set
            {
                // Обчислюємо індекс елемента в одновимірному масиві
                int index = (j - i + lowerStripWidth) + i * (lowerStripWidth + upperStripWidth + 1);

                // Перевіряємо, чи індекси знаходяться в межах розмірів матриці та діагональних полос
                if (i >= 0 && i < Rows && j >= 0 && j < Cols && Math.Abs(j - i) <= Math.Max(lowerStripWidth, upperStripWidth))
                    // Якщо умови виконуються, присвоюємо нове значення елементу матриці за вказаними індексами
                    data[index] = value;
            }
        }


    }

}

