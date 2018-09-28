using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object c = 123456789L;
            object w = "abcde";
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(w);

            Console.WriteLine(a.GetType()); //32로 통일되었지만
            Console.WriteLine(c.GetType());//롱은 아직 통일되지 않았다!(?)
            Console.WriteLine(w.GetType());

            Console.WriteLine("=============================");

            if (a.GetType() == System.Type.GetType("System.Int32"))
            {
                Console.WriteLine("a is Int32");
            }

            float d = 1.2345f;
            int e = (int)d;
            int f = 12345;
            float g = 3.1415f;

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);

            Console.WriteLine(f.ToString("D8")); // WriteLine("{0:D8}",f);
            Console.WriteLine(g.ToString("F2"));

            Console.WriteLine("=============================");

            string h = "123456";
            string m = "1.23456";
            int o = int.Parse(h);
            float p = float.Parse(m);
            Console.WriteLine(o);
            Console.WriteLine(p);

            Console.WriteLine("=============================");

            const int q = 567;

            EFruit tmpEF = EFruit.EF_Banana;
            Console.WriteLine(tmpEF);
            if (tmpEF == EFruit.EF_Apple) {
                Console.WriteLine("APPLE");
            }
            switch(tmpEF)
            {
                case EFruit.EF_Apple:
                    Console.WriteLine("EF_Apple");
                    break;
                case EFruit.EF_Banana:
                    Console.WriteLine("EF_Banana");
                    break;
                case EFruit.EF_Lemon:
                    Console.WriteLine("EF_Lemon");
                    break;
            }
            Console.WriteLine("===========**************==================");
            int[] tmpPoints = new int[(int)EFruit.EF_Count];
            int i;
            for (i = 0; i < (int)EFruit.EF_Count;i++ )
            {
                tmpPoints[i] = i + 1;
            }
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                tmpPoints[i] = i + 1;
            }
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                Console.Write(tmpPoints[i]);
                Console.Write(" : ");
                Console.WriteLine((EFruit)i);
                Console.WriteLine((int)EFruit.EF_Count);
            }

            Console.WriteLine("=============================");
            int? r = null; // r 에 값이 없음을 표현하기 위해 null, 보통이 아니므로 ?표시
            Console.WriteLine(r.HasValue);
            if(r.HasValue==true)
            {
                Console.WriteLine(r.Value);
            }
            r = 234;
            Console.WriteLine(r.HasValue);
            if (r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }

            Console.WriteLine("=============================");

            int _a = 111;
            int _b = _a + 50;
            int _c = 5 * 7;
            int _d = 123 / 5;
            double _e = _d * 5.0;
            int _f = _a++;
            int _g =_f--;
            string _h = "123"+"456";
            string _j = (_c==35)?"AAA":"BBB";
            int _k = 1 << 4;
            int _l = 1 << 3;
            int _m = (_k | _l);
            int _n = (_k | _l)&(1<< 3);
            _c *= 3;
            Console.WriteLine(_a);
            Console.WriteLine(_b);
            Console.WriteLine(_c);
            Console.WriteLine(_d);
            Console.WriteLine(_e);
            Console.WriteLine(_f);
            Console.WriteLine(_g);
            Console.WriteLine(_h);
            Console.WriteLine(_j);
            Console.WriteLine(_k);
            Console.WriteLine(_l);
            Console.WriteLine(_m.ToString("X8"));
            Console.WriteLine(_n.ToString("X8"));

            //int tmpX = 7; int tmpY = 8;
            //Console.WriteLine("{0:D2} + {1:D2} = {2:D2}", tmpX, tmpY, tmpX + tmpY);

            int[] arr = { 1, 2, 3, 4, 5 }; 
            for (int k = 0; k < arr.Length; k++) 
            { 
                if (arr[k] % 2 == 0) { continue; } 
                Console.Write("{0}", arr[k]); 
            }
            Console.WriteLine();
            int total = 0; int tmpX = 10; 
            Increase(tmpX); total += tmpX; 
            MakeValue(out tmpX); total += tmpX; 
            Increase(ref tmpX); total += tmpX; 
            Console.WriteLine("total : "+total);

            Console.ReadKey();


        }



        public static void Increase(int aValue) { aValue++; }
        public static void Increase(ref int aValue) { aValue++; }
        public static void MakeValue(out int aValue) { aValue = 15; } 

            enum EFruit
            {
                EF_Apple,
                EF_Banana,
                EF_Lemon,
                EF_Count 
            }//쉽게 ArrayList, List로 바꿀 수 있음!

    }
}
