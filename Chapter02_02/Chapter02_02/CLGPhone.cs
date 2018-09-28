using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class CLGPhone:CSmartPhone
    {
        public CLGPhone()
        { 
        }

        public override string GetMarket()
        {
            string parentMarket = base.GetMarket();
            return (parentMarket + ", U+ MARKET");
        }
        public int GetButtonCount()
        {
            return (2);
        }

    }
}
