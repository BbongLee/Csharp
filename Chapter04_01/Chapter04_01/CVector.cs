using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class CVector
    {
        public int theX;
        public int theY;
        public CVector(int aX, int aY)
        {
            theX = aX;
            theY = aY;
        }

        public int this[int aIndex]
        {
            get 
            {
                if (aIndex == 0) return (theX);
                if (aIndex == 1) return (theY);
                throw new IndexOutOfRangeException();
            }
            set 
            {
                if (aIndex == 0)
                {
                    theX = value;
                }
                else if (aIndex == 1)
                {
                    theY = value;
                }
                else 
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

    }
}
