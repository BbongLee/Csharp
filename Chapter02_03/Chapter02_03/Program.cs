using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{

    class Program
    {
        static void Main(string[] args)
        {
            CPartialClass tmpPC = new CPartialClass();
            Console.WriteLine("tmpPC.theModule1 : " + tmpPC.theModule1);
            Console.WriteLine("tmpPC.theModule2 : " + tmpPC.theModule2);
            Console.WriteLine("tmpPC.FunctionA() : " + tmpPC.FunctionA());
            Console.WriteLine("tmpPC.FunctionB() : " + tmpPC.FunctionB());

            CVector2i tmpV2 = new CVector2i();
            tmpV2.X = 3; //Set함수 호출
            //property가 알아서 호출해준당!!
            Console.WriteLine("tmpV2.X : " + tmpV2.X); //get함수호출개

            tmpV2.Y = 7;
            Console.WriteLine("tmpV2.Y : " + tmpV2.Y);
            Console.WriteLine("tmpV2.theY : " + tmpV2.theY);

            //tmpV2.Info = "AAA"; //set 없고 get만 있으므로
            Console.WriteLine("tmpV2.Info : " + tmpV2.Info);

            CVector2i tmpV3 = new CVector2i() { X = 8, Y = 9 };
            Console.WriteLine("tmpV3.Info : " + tmpV3.Info);

            //알아서 간단한 익명클래스가 만들어짐!!!활용도가높대요!
            var tmpStudent = new { Number = 1, Name = "Mirim" };
            Console.WriteLine("tmpStudent.Number : " + tmpStudent.Number);
            Console.WriteLine("tmpStudent.Name : " + tmpStudent.Name);


            int m = 1 << 4; int n = 1 << 2; int k = m | n; 
            Console.WriteLine(k.ToString("X4"));


           
        int i; for( i = 0; i < (int) EFruit.EF_Count; i++ ) { Console.WriteLine( (EFruit) i ); } 

            Console.ReadKey();




        }
    }
    enum EFruit { EF_Apple, EF_Banana, EF_Lemon, EF_Count } 
    partial class CPartialClass
    {
        public CPartialClass() 
        {
            theModule1 = 3;
            theModule2 = 5;
        }
        public int theModule2;
        public int FunctionB() {
            return (2);
        }
    }
}
