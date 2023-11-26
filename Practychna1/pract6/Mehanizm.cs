using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practychna1.pract6
{
    public class Mehanizm : INodeStart, IDone, IOnWork
    {
        int detalsCount;

        public Mehanizm(int detalsCount)
        {
            this.detalsCount = detalsCount;
        }

        public int DetalsCount { get { return detalsCount; } set { detalsCount = value; } }

        public string nodeStart()
        {
            return "Вузол запустив механізм обробки деталі";
        }

        public string onProces()
        {
            
            return "Механізм в роботі, залишилось обробити - " + detalsCount.ToString();
        }

        public string done()
        {
            return "Механізм закічнив роботу та створив виробів - " + detalsCount.ToString();
        }

        public void oneDoneProduct()
        {
            this.detalsCount = this.detalsCount - 1;
        }

        public void Mechanizm_Event()
        {
            MessageBox.Show(nodeStart());
            while (detalsCount > 0)
            {
                oneDoneProduct();
                MessageBox.Show(onProces());
            }

        }
    }
}
