using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Chapter04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input File Name : ");
            String fileName = Console.ReadLine();

            Console.WriteLine("Load:{0}", fileName);

            long tmpL = 65;
            String tmpSL = "ABCDEF";
            long strSize = Encoding.UTF8.GetByteCount(tmpSL);
            byte[] strBytes = Encoding.UTF8.GetBytes(tmpSL);
            byte[] sizeBytes = BitConverter.GetBytes(strSize);


            FileStream tmpFS = new FileStream(fileName, FileMode.OpenOrCreate);
            byte[] byteL = BitConverter.GetBytes(tmpL);
            tmpFS.Write(byteL, 0, sizeof(long));

            tmpFS.Write(sizeBytes, 0, sizeof(long));
            tmpFS.Write(strBytes, 0, (int)strSize);

            tmpFS.Close();
   
            /*
            FileStream tmpFS = new FileStream(fileName, FileMode.Open);
            byte[] byteR = new byte[sizeof(long)];
            tmpFS.Read(byteR, 0, sizeof(long));
            long tmpR = BitConverter.ToInt64(byteR, 0);
            tmpFS.Close();
            Console.WriteLine("N:{0}", tmpR);
            */




            Console.ReadKey();
        }
    }
}
