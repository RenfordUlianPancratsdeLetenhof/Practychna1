using System;

namespace Practychna1
{
    internal class Array2D
    {
        public bool error = false;
        int x_length;
        int y_length;
        int[,] array;

        public int X_length { get { return x_length; } set { x_length = value; } }
        public int Y_length { get { return y_length; } set { y_length = value; } }

        public int this[int i, int j]
        {
            get
            {
                if (1 <= i && i <= 10 && 1 <= j && j <= 7)
                {
                    return array[i - 1, j - 1];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (1 <= i && i <= 10 && 1 <= j && j <= 7)
                {
                    array[i - 1, j - 1] = value;
                }
                else
                {
                    error = true;
                }
            }
        }

        public Array2D(int a_length, int b_length)
        {
            x_length = a_length;
            y_length = b_length;
            array = new int[x_length, y_length];
            Random rand = new Random();

            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    array[i, j] = rand.Next(1, 10);
                }
            }
        }

        public int CalculateSumOfElementsWithBothOddIndices()
        {
            int sum = 0;

            for (int i = 1; i <= x_length; i++)
            {
                for (int j = 1; j <= y_length; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        sum += this[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
