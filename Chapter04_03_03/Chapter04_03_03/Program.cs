using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_03_03
{
    class Program
    {
        static void RunCount()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void RunString(object strs)
        {
            String[] tmpStrs = (String[])strs;
            foreach (String iter in tmpStrs)
            {
                Console.WriteLine(iter);
            }
        }

        static int RunFibonacci(object aIndex)
        {
            int tmpIndex = (int)aIndex;
            if (tmpIndex == 0)
            {
                return (1);
            }
            if (tmpIndex == 1)
            {
                return (1);
            }

            return (RunFibonacci(tmpIndex - 1) + RunFibonacci(tmpIndex - 2));
        }

        static void Main(string[] args)
        {
            Task tmpTask1 = new Task(RunCount);
            tmpTask1.Start();

            Task tmpTask2 = new Task(RunString, new String[] { "AAA", "BBB", "CCC" });
            tmpTask2.Start();

            tmpTask1.Wait();
            tmpTask2.Wait();

            Task<int> tmpTask3 = new Task<int>(RunFibonacci, 30);
            tmpTask3.Start();
            tmpTask3.Wait();
            Console.WriteLine("Fibo:{0} / {1}", 30, tmpTask3.Result);

            int i;
            int[] fibos = { 15, 20, 25, 30, 35 };
            Task<int>[] tmpTasks = new Task<int>[fibos.Length];

            for (i = 0; i < fibos.Length; i++)
            {
                tmpTasks[i] = new Task<int>(RunFibonacci, fibos[i]);
                tmpTasks[i].Start();
            }
            for (i = 0; i < fibos.Length; i++)
            {
                tmpTasks[i].Wait();
                Console.WriteLine("Fibo : {0} / {1}", fibos[i], tmpTasks[i].Result);
            }
                Console.WriteLine("END");

            Console.ReadKey();
        }
    }
}
