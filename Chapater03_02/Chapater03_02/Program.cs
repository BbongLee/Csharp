using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapater03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CPoint4i tmpP = new CPoint4i();
            tmpP.theX = 3;
            Console.WriteLine("X : {0}", tmpP.theX);
            Console.WriteLine("[0] : {0}", tmpP[0]);

            tmpP[1] = 8;
            Console.WriteLine("Y : {0}", tmpP.theX);
            Console.WriteLine("[1] : {0}", tmpP[1]);

            tmpP["Z"] = 36;
            Console.WriteLine("Z : {0}", tmpP.theZ);
            Console.WriteLine("[2] : {0}", tmpP[2]);
            Console.WriteLine("\"Z\":{0}", tmpP["Z"]);

            Console.WriteLine();
            string[] tmpStrs = { "X", "Y", "Z", "W" };
            foreach (string iter in tmpStrs)
            {
                Console.WriteLine("{0}:{1}", iter, tmpP[iter]);
            }

            List<int> tmpList = new List<int>();
            tmpList.Add(35);
            tmpList.Add(27);
            tmpList.Add(10);

            Console.WriteLine(tmpList[0]);
            Console.WriteLine(tmpList[1]);

            foreach(int iter in tmpList)
            {
                Console.WriteLine(iter);
            }
            tmpList.Sort();
            foreach (int iter in tmpList)
            {
                Console.WriteLine(iter);
            }

            List<string> strList = new List<string>();
            strList.Add("VIPS");
            strList.Add("Ashley");
            strList.Add("OutBack");

            strList.Sort();
            foreach (string iter in strList)
            {
                Console.WriteLine(iter);
            }
            if (strList.Contains("VIPS") == true)
            {
                Console.WriteLine("Find!");
            }

            List<List<string>> itemList = new List<List<string>>();
            List<string> itemAttack = new List<string>();
            itemAttack.Add("Sword");
            itemAttack.Add("Axe");
            itemAttack.Add("Spear");
            itemList.Add(itemAttack);

            List<string> itemDefend = new List<string>();
            itemDefend.Add("Sword");
            itemDefend.Add("Axe");
            itemList.Add(itemDefend);

            List<string> itemPortion = new List<string>();
            itemPortion.Add("Sword");
            itemPortion.Add("Axe");
            itemPortion.Add("Spear");
            itemPortion.Add("Spear");
            itemList.Add(itemPortion);

            foreach (List<string> iterList in itemList)
            {
                foreach (string iterStr in iterList)
                {
                    Console.Write(iterStr);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(itemList[0][1]);
            Console.WriteLine(itemList[1][0]);
            Console.WriteLine(itemList[2][2]);

            SortedList<string, int> tmpSL = new SortedList<string, int>();
            tmpSL.Add("Hong", 89);
            tmpSL.Add("Lee", 85);
            tmpSL.Add("Choi", 75);
            tmpSL.Add("Kim", 92);
            foreach (KeyValuePair<string, int> iter in tmpSL)
            {
                Console.WriteLine("{0}ccc : {1}", iter.Key, iter.Value);
            }
            Console.WriteLine("");
            foreach (string key in tmpSL.Keys)
            {
                Console.WriteLine("{0} : {1}", key, tmpSL[key]);
            }

            tmpSL["Jung"] = 89;//Add
            tmpSL["Hong"] = 95;//Modify
            Console.WriteLine("");
            foreach (string key in tmpSL.Keys)
            {
                Console.WriteLine("{0} : {1}", key, tmpSL[key]);
            }

            tmpSL["Choi"] = 92; //Modify

            Console.WriteLine("===Score List===");

            SortedList<int, List<string>> tmpScores = new SortedList<int, List<string>>();
            foreach (KeyValuePair<string, int> iter in tmpSL)
            {
                string tmpName = iter.Key;
                int tmpScore = iter.Value;

                if (tmpScores.ContainsKey(tmpScore) == true)
                {
                    tmpScores[tmpScore].Add(tmpName);
                }
                else 
                {
                    List<string> tmpArrs = new List<string>();
                    tmpArrs.Add(tmpName);
                    tmpScores.Add(tmpScore, tmpArrs);
                }
            }

            foreach (int iterScore in tmpScores.Keys.Reverse())
            {
                Console.Write("{0} : ", iterScore);
                foreach (string iterName in tmpScores[iterScore])
                {
                    Console.Write("{0}, ", iterName);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
