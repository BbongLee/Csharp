using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_02
{
    class CMyClass
    {
        public static int Add(int a, int b) //static 이 붙으면 객체를 생성하지 않고 직접호출!!
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            return (a + b);
        }
        public int Multiply(int a, int b)  //객체생성하기!!
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            return (a * b);
        }
    }
}
