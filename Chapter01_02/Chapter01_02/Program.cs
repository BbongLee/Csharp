using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            long b = 12345678901L;

            Console.WriteLine("   int : {0}", a);
            Console.WriteLine("   int : {0:D4}", a); //4칸출력, 빈칸은 0으로 채우기
            Console.WriteLine("  long : {0}", b);

            //Console.WriteLine("int : {0}", 1234567 * 1234567); int범위를 넘어섬
            Console.WriteLine("  long : {0}", 1234567L * 1234567L);

            float c = 1.23456789f;
            double d = 1.234567890123;

            Console.WriteLine(" float : {0}", c);
            Console.WriteLine(" float : {0:F2}", c);
            Console.WriteLine("double : {0}", d);

            char e = 'a';
            string f = "abcdefgh";
            string g = "가나다라마바";

            Console.WriteLine("  char : {0}", e);
            Console.WriteLine("string : {0}", f);
            Console.WriteLine("string : {0}", g);

            string h = "\nUnicode Test\n";
            string i = "\u2605\u2606";

            Console.WriteLine("{0}", h);
            Console.WriteLine("\t code : {0}", i);

            int res1 = CMyClass.Add(5, 6);
            Console.WriteLine("{0}", res1);

            CMyClass tmpMC = new CMyClass();
            int res2 = tmpMC.Multiply(5, 6);
            Console.WriteLine("{0}", res2);

            Console.ReadKey();
        }
    }
}
