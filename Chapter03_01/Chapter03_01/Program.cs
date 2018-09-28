using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            numbers[0] = 10;
            numbers[1] = 15;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);

            int[] nums = new int[] { 2, 3, 5, 8, 13 };
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[3]);

            int i;
            Console.WriteLine();
            Console.Write("Nums : ");
            for (i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

            int[] num2s = { 3, 1, 4, 1, 5, 9, 2 };
            Console.WriteLine();
            Console.Write("num2s : ");
            for (i = 0; i < num2s.Length; i++)
            {
                Console.Write("{0}, ", num2s[i]);
            }

            Console.WriteLine();
            Console.Write("num2s : ");
            foreach (int iter in num2s)
            {
                Console.Write("{0}, ", iter);
            }

            String[] tmpStrs = { "C++", "C#", "Java", "Swift" };
            Console.WriteLine();
            Console.Write("tmpStrs : ");
            foreach (String iter in tmpStrs)
            {
                Console.Write("{0}, ", iter);
            }

            String[,] tmpStrLists = { { "Apple", "Banana", "Lemon" }, { "Pizza", "Pasta", "Risoto" } };
            Console.WriteLine();
            Console.WriteLine(tmpStrLists[0, 1]);
            Console.WriteLine(tmpStrLists[1, 2]);

            
            int j;
            for (i = 0; i < tmpStrLists.GetLength(0); i++)
            {
                for (j = 0; j < tmpStrLists.GetLength(1); j++)
                {
                    Console.Write("{0}, ", tmpStrLists[i, j]);
                }
                Console.WriteLine();
            }

            foreach (String iter in tmpStrLists)
            {
                Console.Write("{0}, ", iter);
            }

            Console.ReadKey();
        }
    }
}
