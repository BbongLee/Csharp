using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{
    class CVector2i
    {
        private int theX; //멤버변수
        //public int GetX(){} //멤버함수
        public int theY;
        public CVector2i()
        {
            theX = 0;
            theY = 0;
        }

        public int X //Property
        {
            get 
            {
                Console.WriteLine("GetX");
                return (theX);
            }
            set 
            {
                Console.WriteLine("SetX");
                theX = value;
            }
        }

        public int Y
        {
            get;
            set;
        }

        public String Info
        {
            get 
            {
                return (String.Format("{0},{1}", X, Y));
            }
        }
    }
}
