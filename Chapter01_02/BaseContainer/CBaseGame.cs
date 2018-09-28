using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseContainer
{
    class CBaseGame
    {
        //배열의 선언
        public int[] number;
        public CBaseGame() {
            number = new int[3];
        }

        public int Initialize() 
        {
            Random rand = new Random();

            int i;
            int[] tempNum = new int[9];
            for (i = 0; i < 9; i++)
            {
                tempNum[i] = i + 1;
            }
            for (i = 0; i < 100; i++)
            {
                int iNum1 = rand.Next(0, 9);
                int iNum2 = rand.Next(0, 9);
                int temp = tempNum[iNum1];
                tempNum[iNum1] = tempNum[iNum2];
                tempNum[iNum2] = temp;
            }
            number[0] = tempNum[0];
            number[1] = tempNum[1];
            number[2] = tempNum[2];
            //겹치지 않는 랜덤 수 3개
            return (1);
        }
        public int CheckNumber(int aNum1, int aNum2, int aNum3, ref int aStrikeCount, ref int aBallCount)
        {
            int i;
            int j;
            int[] input = { aNum1, aNum2, aNum3 };

            aStrikeCount = 0;
            aBallCount = 0;
            for (i = 0; i < 3; i++) 
            {
                for (j = 0; j < 3; j++) 
                { 
                    if (number[i] == input[j])
                    {
                        if (i == j)
                        {
                            aStrikeCount++;
                        }
                        else
                        {
                            aBallCount++;
                        }
                    }
                }
            }
            return (1);
        }
    }
}
