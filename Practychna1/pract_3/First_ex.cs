using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.pract_3
{
    public class First_ex
    {

        private double a_;
        private double b_;
        private double c_;
        public int count;

        public double a { get { return a_; } set { a_ = value; } }
        public double b { get { return b_; } set { b_ = value; } }
        public double c { get { return c_; } set { c_ = value; } }

        public First_ex(double a, double b, double c)
        {
            a_ = a;
            b_ = b;
            c_ = c;
        }

        public int count_of_equal_27()
        {
            if (a_ != 0 && a_ % 27 == 0)
            {
                count++;
            }

            if (b_ != 0 && b_ % 27 == 0)
            {
                count++;
            }

            if (c_ != 0 && c_ % 27 == 0)
            {
                count++;
            }

            return count;
        }
    }
}
