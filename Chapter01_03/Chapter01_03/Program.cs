using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_03
{
    class Program
    {
        class CMyInt
        {
            public int theValue;
    /*        public override string ToString()
            {
                Console.WriteLine("-");
                return (theValue.ToString());
            }*/
        }
        static void Main(string[] args)
        {
            int a = 12345;
            int b = a;
            Console.WriteLine("Before");
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);

            a = 98765;
            Console.WriteLine("After");
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);

            object c = 12345;//boxing
            object d = c;
            Console.WriteLine("Before");
            Console.WriteLine("c : {0}", c);
            Console.WriteLine("d : {0}", d);

            c = 98765; //boxing
            Console.WriteLine("After");
            Console.WriteLine("c : {0}", c);
            Console.WriteLine("d : {0}", d);

            CMyInt e = new CMyInt();
            e.theValue = 12345;
            CMyInt f = e;
            Console.WriteLine("Before CMyInt");
            Console.WriteLine("e : {0}", e);
            Console.WriteLine("f : {0}", f);
            e.theValue = 98765;
            Console.WriteLine("After");
            Console.WriteLine("e : {0}", e);
            Console.WriteLine("f : {0}", f);
            /*
            Console.Write("Input Name :");
            string tmpName = Console.ReadLine();
            Console.WriteLine("YourName : {0}", tmpName);

            Console.Write("\nInput Char: ");
            ConsoleKeyInfo tmpKey = Console.ReadKey();

            int i;
            for (i = 0; i < tmpName.Length; i++) {
                if (tmpName[i].Equals(tmpKey.KeyChar)==true)
                {
                    break;
                }
            }
            if (i == tmpName.Length)
            {
                Console.WriteLine("\nChar:{0} Fail", tmpKey.KeyChar);
            }
            else 
            {
                Console.WriteLine("\nChar:{0} Success!", tmpKey.KeyChar);
            }
            */
            int tmpSW = 1;
            switch (tmpSW)
            { 
                case 0:
                    Console.WriteLine("SW : 0");
                    break;
                case 1:
                    Console.WriteLine("SW : 1");
                    break;
                default:
                    Console.WriteLine("NONE");
                    break;
            }
            string strSW = "apple";
            switch (strSW)
            { 
                case "apple":
                    Console.WriteLine("apple. apple");
                    break;
                case "banana":
                    Console.WriteLine("banana. banana");
                    break;
                default:
                    Console.WriteLine("Fruits");
                    break;
            }

            int i;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            foreach (int iter in arr)
            {
                Console.Write("{0} ", iter);
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
