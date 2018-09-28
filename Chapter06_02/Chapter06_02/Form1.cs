using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            thePen = new Pen(Color.Red);
            theBrush = new SolidBrush(Color.Navy);
            theFont = new Font("굴림", 15);

            imgList = new List<Image>();

            int i;
            for (i = 0; i < 16; i++)
            {
                String tmpName = String.Format("pic_{0}.png", (char)(97 + i)); //효율적으로 사진 불러오기
                Image tmpl = Image.FromFile(tmpName);
                imgList.Add(tmpl);
            }
            theTick = 0;
            theGameTick = 0;
            timer1.Start();

            Random tmpR = new Random();
            theViewIndices = new int[16];
            for (i = 0; i < 16; i++)
            {
                theViewIndices[i] = i;
            }
            for (i = 0; i < 1000; i++)
            {
                int tmpSwap;
                int tmpRand1 = tmpR.Next(16);
                int tmpRand2 = tmpR.Next(16);
                tmpSwap = theViewIndices[tmpRand1];
                theViewIndices[tmpRand1] = theViewIndices[tmpRand2];
                theViewIndices[tmpRand2] = tmpSwap;
            }

            theEmptyIndex = 15;
            theTouchIndex = -1;

            bSuccess = 0;
        }
        Pen thePen;
        Brush theBrush;
        Font theFont;

        List<Image> imgList;
        int scrX = 50;
        int scrY = 50;

        int theTick;
        int theGameTick;

        int[] theViewIndices;
        int theEmptyIndex;
        int theTouchIndex;
        int bSuccess;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            String strTime = String.Format("Time:{0:D3}", 99 - (theTick - theGameTick) / 20);
            //(x좌표, y좌표)or (x좌표, y좌표, x크기, y크기)
            e.Graphics.DrawRectangle(thePen, 2, 2, 99 - (theTick - theGameTick) / 20, 10);
            e.Graphics.DrawString(strTime, theFont, theBrush, 2, 14);
            // 대박 신기해!!!!!!!!!!!!!!!!!!!! 졸라맨 그릴거같음o<-<

            int i;
            for (i = 0; i < 16; i++) //1차원배열, %와 /로 이차원 배열처럼 만들 수 있다! 훨씬 더 편하다!
            {
                if (theViewIndices[i] == theEmptyIndex)
                {
                    continue;
                }
                e.Graphics.DrawImage(imgList[theViewIndices[i]], scrX + (i % 4) * 100, scrY + (i / 4) * 100, 100, 100);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            theTick++;
            Invalidate();
        }

        int[][] theWays = {
                          new int[] {1,4}, //0번방 이미지는 1,4칸에만 이동 가능!
                          new int[] {0,2,5}, //1번방 이미지 0,2,5칸에!
                          new int[] {1,3,6},
                          new int[] {2,7},
                          new int[] {0,5,8},
                          new int[] {1,4,6,9},
                          new int[] {2,5,7,10},
                          new int[] {3,6,11},
                          new int[] {4,9,12},
                          new int[] {5,8,10,13},
                          new int[] {6,9,11,14},
                          new int[] {7,10,15},
                          new int[] {8,13},
                          new int[] {9,12,14},
                          new int[] {10,13,15},
                          new int[] {11,14}
                          };
      
        public int CheckSuccess() 
        {
            int i;
            for (i = 0; i < 16; i++)
            { 
                if(theViewIndices[i]==theEmptyIndex)
                {
                    continue;
                }
                if (theViewIndices[i] == i)
                {
                    continue;
                }
                break;
            }
            if(i==16)
            {
                return (1);
            }
            return (0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int i;
            int tmpX = e.X;
            int tmpY = e.Y;
            int tmpDP = 100;
            theTouchIndex = -1;
            for (i = 0; i < 16; i++)
            {
                if (scrX + (i % 4) * tmpDP < tmpX && tmpX < scrX + (i % 4) * tmpDP + tmpDP)
                {
                    if (scrY + (i / 4) * tmpDP < tmpY && tmpY < scrY + (i / 4) * tmpDP + tmpDP)
                    {
                        theTouchIndex = i;
                        break;
                    }

                }
            }
            if (0 <= theTouchIndex && theTouchIndex < 16)
            {
                for (i = 0; i < theWays[theTouchIndex].Length; i++)
                {
                    int tmpWayPos = theWays[theTouchIndex][i];
                    if (theViewIndices[tmpWayPos] == theEmptyIndex)
                    {
                        int tmpSwap;
                        tmpSwap = theViewIndices[tmpWayPos];
                        theViewIndices[tmpWayPos] = theViewIndices[theTouchIndex];
                        theViewIndices[theTouchIndex] = tmpSwap;
                    }
                }
                bSuccess = CheckSuccess();
            }
            Invalidate();
            if (bSuccess == 1)
            {
                MessageBox.Show("완료했습니다");
            }
        }

        
    }
}
