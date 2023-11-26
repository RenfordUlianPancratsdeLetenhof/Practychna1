using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practychna1.pract6
{
    public class Worker : IPut
    {

       public string putDetail()
        {
            return "Оператор поставив деталі та запустив вузол";
        }

        public void Worker_Event()
        {
            MessageBox.Show(putDetail());
        }

    }
}
