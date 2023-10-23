using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1
{
    internal class Tabul
    {

        public double[,] result = new double[1000, 2];

        public int real_num = 0;

        private double f1(double x)
        {
            return (Math.Cos(Math.Pow(x, 3)) - (4 * x) + 4) / (Math.Pow(x, 3) - Math.Log(Math.Abs(x) + 1));
        }

        private double f2(double x)
        {
            return (Math.Pow(Math.Sin(x + 2), 2)) / (Math.Pow(2 * Math.Pow(x, 2) + Math.Pow(x, 4) + 1, 1/3));
        }

        private double f3(double x)
        {
            return (Math.Sqrt(Math.Pow(Math.Abs(x), 3)) * Math.Pow(Math.Sin(x), 3)) / (Math.Pow(Math.Cos(x + 1), 2));
        }

        public void tab(double xn = -2.25, double xk = 34.9, double h = 0.5, double a = 3)
        {
            double x = xn, y;
            int counter = 0;
            while (x <= xk)
            {
                if (x <= 0)
                {
                    y = f1(x);
                }
                else
                {
                    if (x >= 0 && x < a)
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                result[counter, 0] = x;
                result[counter, 1] = y;
                x = x + h;
                counter++;
            }
            real_num = counter;
        }


    }
}
