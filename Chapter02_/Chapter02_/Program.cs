using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_
{
    class Program
    {
        static void Main(string[] args)
        {
            CMyClass tmpMC1 = new CMyClass();
            Console.WriteLine(tmpMC1.GetName());

            Console.WriteLine(new CMyClass(1).GetName()); //º0º//
            Console.WriteLine(new CMyClass(3, "AAA").GetName());

            int a = 5;
            int b = 5;
            tmpMC1.Increase(a);//5
            tmpMC1.Increase(ref b);//6

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c;
            tmpMC1.MakeValue(out c);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
