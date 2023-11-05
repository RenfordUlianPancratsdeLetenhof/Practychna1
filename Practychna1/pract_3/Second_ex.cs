using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.pract_3
{
    public class Second_ex
    {
        private int a_;
        private int b_;

        public Second_ex(int a, int b)
        {
            a_ = a;
            b_ = b;
        }

        private int a {  get { return a_; } set { a_ = value; } } 
        private int b { get { return b_; }  set { b_ = value; } }

        public int sum ()
        {
            int sum_of_ex = 0;

            if (a_ > b_)
            {
                throw
                    new ArgumentOutOfRangeException("А повинно бути більше, а ніж Б ");
            }
           
            if (a_ == b_)
            {
                return 0;
            }
            else
            {
                for (int i = a_; i <= b_; i++)
                {
                    if (i % 17 == 0 && i % 4 == 2)
                    {
                        sum_of_ex += i;
                    }
                }
            }
            return sum_of_ex;
        }

    }
}
