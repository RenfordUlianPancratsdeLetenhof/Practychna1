using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.pract4
{
    public class IntArray
    {
        public int[] a;
        public int count = 0;

        int lenght = 0;

        public int Length {  get { return lenght; } set { lenght = value; } } 

        public IntArray(int n) {
            a = new int[n];    
        }

        public int calculation()
        {
            Array.Resize(ref a, lenght);
            for (int i = 0; i < lenght; i++)
            {
                bool isUnique = true;

              
                for (int j = 0; j < lenght; j++)
                {
                    if (i != j && a[i] == a[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    count++;
                }
            }

            return count;
        }
    }

}

