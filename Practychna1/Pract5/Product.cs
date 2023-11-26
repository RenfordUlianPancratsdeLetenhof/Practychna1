using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practychna1.Pract5
{
    public class Product:IComparable
    {
        string type;
        double cost;
        string variety;
        int count;

        public Product(string type, string variety, double cost, int count)
        {
            Types = type;
            Cost = cost;
            Variety = variety;
            Count = count;
        }

        public Product() { }

        public string Types { get;  set; }
        public string Variety { get;  set; }

        public double Cost { get { return this.cost; }
            set { if (value > 0)
                    this.cost = value;
                else
                    throw new ArgumentException("Ціна не може бути нижче 0");
            } }

        public int Count
        {
            get { return this.count; }
            set
            {
                if (value > 0)
                    this.count = value;
                else
                    throw new ArgumentException("Кількість не може бути нижче 0");
            }
        }

        public int CompareTo(object obj)
        {
            Product product = obj as Product;

            return count.CompareTo(product.Count);
        }



    }
}
