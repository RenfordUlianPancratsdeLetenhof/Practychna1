using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.pract4
{
    internal class FileRead:IRead
    {
        public void read (string patch, IntArray a)
        {
            using (StreamReader sr = new StreamReader(patch, Encoding.Default)) {

                string lines = "";
                try
                {
                    int i = 0;
                    while ((lines = sr.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToInt32(lines);
                        i++;
                    }
                    a.Length = i;
                    sr.Close();

                } catch {
                    throw new AccessViolationException("Error in file ");
                }

            }
        }
    }
}
