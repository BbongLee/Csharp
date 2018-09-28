using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_03
{
    class Program
    {
        static void CopyArray<T>(T[] aSource, out T[] aTarget)
        {
            if (aSource.Length == 0)
            {
                aTarget = null;
                return;
            }

            aTarget = new T[aSource.Length];
/*            int i;
            for (i = 0; i < aSource.Length; i++)
            {
                aTarget[i] = aSource[i];
            }
 */
            int i=0;
            foreach(T iter in aSource)
            {
                aTarget[i] = iter;
                i++;
            }

            return;
        }
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            int[] intRes;
            CopyArray<int>(intArr, out intRes);
            foreach (int iter in intRes) 
            {
                Console.WriteLine("{0}", iter);
            }

            string[] strArr = { "A", "B", "C", "D", "E" };
            string[] strRes;
            CopyArray<string>(strArr, out strRes);
            foreach (string iter in strRes)
            {
                Console.WriteLine("{0}", iter);
            }

            CPoint2i[] pxArr = { new CPoint2i(1, 2), new CPoint2i(3, 4), new CPoint2i(5, 6) };
            CPoint2i[] pxRes;
            CopyArray<CPoint2i>(pxArr, out pxRes);
            foreach (CPoint2i iter in pxRes)
            {
                Console.WriteLine("({0}, {1})", iter.theX, iter.theY);
            }

            CPoint2<int> tmpP1 = new CPoint2<int>();
            tmpP1.SetXY(3, 5);
            Console.WriteLine("({0}, {1}) : {2}", tmpP1.GetX(), tmpP1.GetY(), tmpP1.GetX() + tmpP1.GetY());

            CPoint2<float> tmpP2 = new CPoint2<float>();
            tmpP2.SetXY(1.3f, 3.1f);
            Console.WriteLine("({0}, {1}) : {2}", tmpP2.GetX(), tmpP2.GetY(), tmpP2.GetX() + tmpP2.GetY());

            CPoint2<bool> tmpP3 = new CPoint2<bool>();
            //tmpP3.SetXY(true, false);
            tmpP3.X = true;
            tmpP3.Y = false;
            Console.WriteLine("({0}, {1})", tmpP3.X, tmpP3.Y);

            CPoint2<string> tmpP4 = new CPoint2<string>();
            tmpP4.X = "Map-X-A";
            tmpP4.Y = "Map-Y-3";
            Console.WriteLine("({0}, {1})", tmpP4.X, tmpP4.Y);

            CPoint2<string>[] p2Arr = { 
                                          new CPoint2<string>("A","B"),
                                          new CPoint2<string>("M","N"),
                                          new CPoint2<string>("X","Y")
                              };
            CPoint2<string>[] p2Res;
            CopyArray<CPoint2<string>>(p2Arr, out p2Res);
            foreach (CPoint2<string> iter in p2Res)
            {
                Console.WriteLine(": ({0}, {1})", iter.X, iter.Y);
            }


            Console.ReadKey();
        }
    }
}
