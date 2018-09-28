using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Chapter04_03
{
    class Program
    {
        static void Run()
        {
            int i;
            int tmpCount = theCount;
            for (i = 0; i < 10; i++) 
            {
                Console.WriteLine("{0} : {1}", tmpCount, i);
                Thread.Sleep(100);
            }
        }

        static void Run2()
        {
            int i;
            Random tmpR = new Random();
            int tmpS = tmpR.Next(9) + 1;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", tmpS, i, tmpS*i);
                Thread.Sleep(100);
            }
        }

        static int theCount;

        static int theValue1=0;
        static void Increase1()
        {
            int i;
            for (i = 0; i < 10000; i++)
            {
                theValue1++;
            }
        }

        static int theValue2 = 0;
        static object theObj = new object();

        static void Increase2()
        {
            int i;
            for (i = 0; i < 10000; i++)
            {
                lock ("AAA")
                {
                    theValue2++;
                }
            }
        }





        static void Main(string[] args)
        {
            /*
            Thread tmpT1 = new Thread(new ThreadStart((Run)));
            tmpT1.Start();

            tmpT1.Join();

            theCount = 0;

            ConsoleKeyInfo tmpCKI;
            tmpCKI = Console.ReadKey();
            while (tmpCKI.KeyChar != 'q')
            {
                Thread tmpT2;

                if (tmpCKI.KeyChar == 'a')
                {
                    tmpT2 = new Thread(new ThreadStart((Run)));
                }
                else
                {
                    tmpT2 = new Thread(new ThreadStart((Run2)));
                }
                tmpT2.Start();

                theCount++;
                tmpCKI = Console.ReadKey();
            }
            */

            int i;
            Thread[] testThread = new Thread[100];
            for (i = 0; i < 100; i++)
            {
                testThread[i] = new Thread(new ThreadStart((Increase1)));
                testThread[i].Start();
            }

            for (i = 0; i < 100; i++)
            {
                testThread[i].Join();
            }

            Console.WriteLine("value1:{0}", theValue1);


                Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
