using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Practychna1.Pract5
{
    internal class Products
    {

        public List<Product> products = new List<Product>();

        XmlSerializer serializer = new XmlSerializer(typeof (List<Product>));
        
        public void add(Product product)
        {
            products.Add(product);
        }

        public void remove(int i) {
            products.RemoveAt(i);
        }

        public void sort()
        {
            SortByCount sbc = new SortByCount();
            products.Sort(sbc);
        }

        public void WriteFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Create,
                FileAccess.Write, FileShare.None);

            serializer.Serialize(fstream, products);
            fstream.Close();
        }

        public void readFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Open,
                FileAccess.Read, FileShare.None);

            products = serializer.Deserialize(fstream) as List<Product>;
            fstream.Close();
        }

    }
}