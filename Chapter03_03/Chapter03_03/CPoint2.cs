using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_03
{
    class CPoint2<T>
    {
        private T theX;
        private T theY;

        public CPoint2()
        {
        }

        public CPoint2(T aX, T aY)
        {
            theX = aX;
            theY = aY;
        }

        public void SetXY(T aX, T aY)
        {
            theX = aX;
            theY = aY;
        }

        public T GetX()
        {
            return (theX);
        }

        public T GetY()
        {
            return (theY);
        }

        public T X
        {
            get 
            {
                return (theX);
            }
            set
            {
                theX = value;
            }
        }

        public T Y
        {
            get
            {
                return (theY);
            }
            set
            {
                theY = value;
            }
        }
    }
}
