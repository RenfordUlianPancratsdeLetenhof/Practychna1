using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practychna1.pract6
{

    delegate void MyEventHandler();
    internal class CreatingProcess
    {

        public event MyEventHandler creating;

        public void areTheDetails(int detailCount)
        {
            if (creating != null && detailCount > 0) { creating(); }
        }

    }
}
