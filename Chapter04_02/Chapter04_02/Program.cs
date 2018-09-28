using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Program
    {

        public delegate int calculate(int a, int b);
        //delegate 
        public static int Plus(int a, int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            return (a + b);
        }
        public static int Minus(int a, int b)
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            return (a - b);
        }
        public static int Multiply(int a, int b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            return (a * b);
        }
        public static int Divide(int a, int b)
        {
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            return (a / b);
        }

        public calculate DelegateOper;
        public event calculate EventOper;

        static void Main(string[] args)
        {

            calculate cal1;
            cal1 = new calculate(Plus);
            int res1 = cal1(3, 5);
            Console.WriteLine("return: {0}", res1);

            calculate cal2;
            cal2 = new calculate(Minus);
            int res2 = cal2(13, 5);
            Console.WriteLine("return: {0}", res2);

            calculate cal3;
            cal3 = new calculate(Multiply);
            int res3 = cal3(3, 5);
            Console.WriteLine("return: {0}", res3);

            calculate cal4;
            cal4 = new calculate(Divide);
            int res4 = cal4(15, 5);
            Console.WriteLine("return: {0}", res4);

            calculate tmpOperation;
            tmpOperation = new calculate(Plus);
            tmpOperation += new calculate(Minus);

            tmpOperation(8, 9);

            tmpOperation += new calculate(Multiply);
            tmpOperation += new calculate(Divide);

            tmpOperation(3, 2);

            Console.WriteLine("Remove");
            tmpOperation -= new calculate(Minus);
            tmpOperation(7, 3);

            tmpOperation += delegate(int a, int b)
            {
                Console.WriteLine("{0}%{1}={2}", a, b, a % b);
                return (a % b);
            };

            tmpOperation(4,3);

            Program tmpPrg = new Program();

            tmpPrg.DelegateOper = new calculate(Plus);
            tmpPrg.DelegateOper += new calculate(Multiply);
            tmpPrg.DelegateOper(2, 3);

            tmpPrg.DelegateOper = new calculate(Minus);
            tmpPrg.DelegateOper += new calculate(Divide);
            tmpPrg.DelegateOper(4,5);

            List<string> tmpStrs = new List<string>();

            tmpStrs.Add("flower");
            tmpStrs.Add("leaf");
            tmpStrs.Add("tree");

            tmpStrs.Sort(delegate(string a, string b) 
            {
                return b.CompareTo(a);
            });

            foreach (string iter in tmpStrs)
            {
                Console.WriteLine(iter);
            }

            List<int> tmpInts = new List<int>();
            tmpInts.Add(51);
            tmpInts.Add(15);
            tmpInts.Add(27);
            tmpInts.Add(41);
            tmpInts.Add(32);

            tmpInts.Sort(delegate(int a, int b)
            {
                return (b.CompareTo(a));
            });
            Console.WriteLine("DES");
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            Console.WriteLine("ASC");
            tmpInts.Sort(delegate(int a, int b)
            {
                return (a.CompareTo(b));
            });

            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            tmpInts.Sort((int a, int b) => b.CompareTo(a)); //=>도입 한 것 : 람다식 !!

            Console.WriteLine("DES");
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            tmpInts.Sort((int a, int b) => a.CompareTo(b)); 

            Console.WriteLine("ASC");
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            calculate AddFunc = (a, b) => a + b;
            calculate MinusFunc = (a, b) => a - b;

            Console.WriteLine("{0}+{1}={2}",5,3,AddFunc(5,3));
            Console.WriteLine("{0}-{1}={2}", 5, 3, MinusFunc(5, 3));

            Func<int, int, int> MulFunc = (a, b) => a * b;
            Func<string, string, string> ConCat = (a, b) => a + b;

            Console.WriteLine("{0}*{1}={2}", 5, 3, MulFunc(5, 3));
            Console.WriteLine("{0}+{1}={2}", "5", "3", ConCat("5", "3"));

            int resInt = 0;
            String resStr = "0";
            Action<int, int> CallAdd=(a, b)=>resInt = a+b;
            Action<string, string> CallStr = (a, b) => resStr = a + b;
            CallAdd(7, 8);
            CallStr("7", "8");

            Console.WriteLine("{0}+{1}={2}", 7, 8, resInt);
            Console.WriteLine("{0}+{1}={2}", "7", "8", resStr);

            Console.ReadKey();
            
        }
    }
}
