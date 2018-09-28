using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOP 1.은닉성 2.상속 3.다형성
namespace Chapter02_02
{
    class CSmartPhone         
    {
        public string theID;
        private string theMarket;

        public CSmartPhone()
        {
            theMarket = "Google";
            theID = "Noname";
        }

        public virtual string GetMarket()
        {
            return (theMarket);
        }

        public int GetButtonCount()
        {
            return (1);
        }
    }
}
