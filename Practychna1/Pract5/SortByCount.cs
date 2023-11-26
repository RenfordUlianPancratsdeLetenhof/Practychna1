using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.Pract5
{
    internal class SortByCount : IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            if (a.Count > b.Count) return 1;
            if (a.Count < b.Count) return -1;
            return 0;
        }
    }
}

