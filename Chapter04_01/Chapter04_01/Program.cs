using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmpStr1 = "15";
            int tmpInt1 = Convert.ToInt32(tmpStr1);
            Console.WriteLine("str1:{0}", tmpInt1);

            string tmpStr2 = "AAA";
 //           int tmpInt2 = Convert.ToInt32(tmpStr2);
            int tmpInt2;
            try
            {
                tmpInt2 = Convert.ToInt32(tmpStr2);
            }
            catch (FormatException e)
            {
                tmpInt2 = 0;
               // Console.WriteLine(e.ToString());
            }
            Console.WriteLine("str2:{0}", tmpInt2);

            int i;
            string[] tmpStrs = { "12", "23", "ABC", "0" };
            try
            {
                for (i = 0; i < 6; i++)
                {
                    try
                    {
                        int tmpInt = Convert.ToInt32(tmpStrs[i]);
                        Console.WriteLine("Num{0} : {1}", i, 100 / tmpInt);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Num{0} : {1}", i, "Convert Error");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num{0} : {1}", i, "Divide By Zero");
                    }
                    catch (Exception) //Error!가 실행되지 않고 이곳에서 캐치된다!!
                    {
                        Console.WriteLine("Unknown Error!");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error!");
            }

            CVector tmpVec = new CVector(1, 2);
            tmpVec[0] = 3;
            tmpVec[1] = 4;
            Console.WriteLine("Vec : {0}, {1}", tmpVec[0], tmpVec[1]);

            try
            {
                tmpVec[2] = 7;
                Console.WriteLine("Vec : {0}, {1}", tmpVec[0], tmpVec[1]);
            }
            catch 
            {
            Console.WriteLine
            }
            Console.ReadKey();
        }
    }
}
