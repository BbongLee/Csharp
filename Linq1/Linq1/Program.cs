using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello", "Program", "C#", "Collections", "Threading" };
            foreach (string iter in words)
            {
                if (iter.Length > 5)
                {
                    Console.WriteLine(iter);
                }
            }

            Console.WriteLine("=== Linq1 ===");
            IEnumerable<string> resWords1 = words.Where(x => x.Length > 5);
            foreach (string iter in resWords1)
            {
                Console.WriteLine(iter);
            }
            Console.WriteLine("=== Linq2 ===");
            var resWords2 = from iter in words
                            where iter.Length > 5
                            select iter;
            foreach (string iter in resWords2)
            {
                Console.WriteLine(iter);
            }
            Console.WriteLine("=== Linq3 ===");
            var resWords3 = words.Where(x => x.Length > 5).Select(x => x.Substring(0, 5));
            foreach (string iter in resWords3)
            {
                Console.WriteLine(iter);
            }
            Console.WriteLine("=== Linq4 ===");
            var resWords4 = from iter in words
                            where iter.Length > 5
                            select iter.Substring(0, 5);
            foreach (string iter in resWords4)
            {
                Console.WriteLine(iter);
            }

            Console.WriteLine("=== Linq5 ===");
            var resWords5 = words.Where(x => x.Contains("o"));
            foreach (string iter in resWords5)
            {
                Console.WriteLine(iter);
            }
            Console.WriteLine("=== Linq6 ===");
            var resWords6 = from iter in words
                            where iter.Contains("o")
                            select iter;
            foreach (string iter in resWords6)
            {
                Console.WriteLine(iter);
            }

            Console.WriteLine("=== Linq7 ===");
            var resWords7 = words
                .Where(x => x.Contains("o"))
                .Select(x =>
                {
                    int tmpIdx = x.IndexOf("o");
                    return (x.Substring(0, tmpIdx + 1));
                });
            foreach (string iter in resWords7)
            {
                Console.WriteLine(iter);
            }

            Console.WriteLine("=== Linq8 ===");
            var resWords8 = from iter in words
                            where iter.Contains("o")
                            select iter.Substring(0, iter.IndexOf("o") + 1);
            foreach (string iter in resWords8)
            {
                Console.WriteLine(iter);
            }

            int[] numbers = { 35, 10, 27, 31, 23, 30, 40, 74, 81, 56, 45, 93 };
            var resNums1 = numbers.Where(x => x > 30);
            var resNums2 = from num in numbers
                           where num > 30
                           select num;
            PrintNumbers(1, resNums1);
            PrintNumbers(2, resNums2);

            var resNums3 = numbers.Where(num => 10 < num && num < 30);
            var resNums4 = from num in numbers
                           where 10 < num && num < 30
                           select num;
            PrintNumbers(3, resNums3);
            PrintNumbers(4, resNums4);

            var resNums5 = numbers.Where((num, idx) => num > 10 && idx < 5);
            PrintNumbers(5, resNums5);

            var resNums6 = numbers.Where((num, idx) => (num > 10 && idx < 5)||(num>50&&idx>=5));
            PrintNumbers(6, resNums6);

            var resNums7 = numbers.OrderBy(num => num);
            var resNums8 = from num in numbers
                           orderby num
                           select num;
            PrintNumbers(7, resNums7);
            PrintNumbers(8, resNums8);


            var resNums9 = numbers.OrderByDescending(num => num);
            var resNums10 = from num in numbers
                           orderby num descending
                           select num;
            PrintNumbers(9, resNums9);
            PrintNumbers(10, resNums10);

            var resNums11 = numbers.OrderBy(num => (num % 10) * 10 + num / 10);
            var resNums12 = from num in numbers
                            orderby (num % 10) * 10 + num / 10
                            select num;
            PrintNumbers(11, resNums11);
            PrintNumbers(12, resNums12);

            var resNums13 = numbers.OrderBy(num => num / 10);
            var resNums14 = from num in numbers
                            orderby num / 10
                            select num;
            PrintNumbers(13, resNums13);
            PrintNumbers(14, resNums14);

            var resNums15 = numbers.OrderBy(num => num % 10);
            var resNums16 = from num in numbers
                            orderby num % 10
                            select num;
            PrintNumbers(15, resNums15);
            PrintNumbers(16, resNums16);

            var resNums17 = numbers.Where(x => x < 40).OrderBy(x => x);
            var resNums18 = from x in numbers
                            orderby x < 40
                            orderby x
                            select x;
            PrintNumbers(17, resNums17);
            PrintNumbers(18, resNums18);

            var resNums19 = numbers.Where(x => x > 40).OrderByDescending(x => x);
            var resNums20 = from x in numbers
                            orderby x > 40
                            orderby x descending
                            select x;
            PrintNumbers(19, resNums19);
            PrintNumbers(20, resNums20);

            Console.WriteLine("Count:{0}", resNums19.Count());
            Console.WriteLine("Max:{0}", resNums19.Max());
            Console.WriteLine("Min:{0}", resNums19.Min());
            Console.WriteLine("Average:{0}", resNums19.Average());

            List<CBook> books = new List<CBook>();
            books.Add(new CBook() { Title = "Java", Author = "Choi", Publisher = "Mirim", Price = 10000 });
            books.Add(new CBook() { Title = "PHP", Author = "Ham", Publisher = "Mirim", Price = 30000 });
            books.Add(new CBook() { Title = "Android", Author = "Ham", Publisher = "Mirim", Price = 25000 });
            books.Add(new CBook() { Title = "swift", Author = "Jung", Publisher = "Mirim", Price = 15000 });
            books.Add(new CBook() { Title = "C#", Author = "Jung", Publisher = "Trutory", Price = 20000 });

            var resBooks1 = books.OrderBy(x => x.Price);
            var resBooks2 = from book in books
                            orderby book.Price
                            select book;

            Console.WriteLine("========");
            Console.WriteLine("resBook1");
            foreach (CBook iter in resBooks1)
            {
                Console.WriteLine("{0} : {1} : {2}", iter.Title, iter.Author, iter.Price);
            }
            Console.WriteLine("resBook2");
            foreach (CBook iter in resBooks2)
            {
                Console.WriteLine("{0} : {1} : {2}", iter.Title, iter.Author, iter.Price);
            }

            var resBooks3 = books.OrderBy(x => x.Price);
            var resBooks4 = from book in books
                            orderby book.Price
                            select book;

            Console.WriteLine("resBook3");
            foreach (CBook iter in resBooks3)
            {
                Console.WriteLine("{0,8} : {1,5} : {2,6}", iter.Title, iter.Author, iter.Price);
            }
            Console.WriteLine("resBook4");
            foreach (CBook iter in resBooks4)
            {
                Console.WriteLine("{0,8} : {1,5} : {2,6}", iter.Title, iter.Author, iter.Price);
            }

            var resBooks5 = books.Where(x => x.Price<23000).Select(x=>new{Title=x.Title,Price=x.Price});
            var resBooks6 = from book in books
                            orderby book.Price < 23000
                            select new { Title = book.Title, Price = book.Price };

            Console.WriteLine("resBook5");
            foreach (var iter in resBooks5)
            {
                Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
            }
            Console.WriteLine("resBook6");
            foreach (var iter in resBooks6)
            {
                Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
            }

            var resBooks7 = books
                .Where(x => x.Price < 23000)
                .OrderBy(x=>x.Title)
                .Select(x => new { Title = x.Title, Price = x.Price });
            var resBooks8 = from book in books
                            where book.Price<23000
                            orderby book.Title
                            select new { Title = book.Title, Price = book.Price };

            Console.WriteLine("resBooks7");
            foreach (var iter in resBooks7)
            {
                Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
            }
            Console.WriteLine("resBook6");
            foreach (var iter in resBooks6)
            {
                Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
            }

            Console.ReadKey();
        }

        public static void PrintNumbers(int aIndex, IEnumerable<int> aNums)
        {
            Console.WriteLine("=== Linq Number {0} ===", aIndex);
            foreach (int iter in aNums)
            {
                Console.Write(iter + ", ");
            }
            Console.WriteLine();
        }
    }
}
