using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseContainer
{
    public partial class BaseGame : Form
    {
        public BaseGame()
        {
            InitializeComponent();
            theGame = new CBaseGame();
            theGame.Initialize();
        }

        private CBaseGame theGame;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            theGame.Initialize();
            tNumber1.Text = "";
            tNumber2.Text = "";
            tNumber3.Text = "";
            statusLabel.Text = "mew game!!!!";
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            //텍스트 박스에서 값을 가지고 와야한다.
            //가지고 온 값이 숫자인지? => 일반 스트링이다
            // 가져온 값을 어떻게 변환하는지? 만약 스트링에 일반 문자가 있다면?
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            try
            {
                //숫자로 먼저 변환
                num1 = Convert.ToInt32(tNumber1.Text);
            }
            catch
            {
                //숫자가 아니면 변환이 되지 않고 catch로 넘어온다
                MessageBox.Show("1번째 텍스트박스에 숫자를 입력해주세요.");
                return;
            }
            try
            {
                //숫자로 먼저 변환
                num2 = Convert.ToInt32(tNumber2.Text);
            }
            catch
            {
                //숫자가 아니면 변환이 되지 않고 catch로 넘어온다
                MessageBox.Show("2번째 텍스트박스에 숫자를 입력해주세요.");
                return;
            }
            try
            {
                //숫자로 먼저 변환
                num3 = Convert.ToInt32(tNumber3.Text);
            }
            catch
            {
                //숫자가 아니면 변환이 되지 않고 catch로 넘어온다
                MessageBox.Show("3번째 텍스트박스에 숫자를 입력해주세요.");
                return;
            }

            if (num1 == num2 || num3 == num1 || num2 == num3) 
            {
                MessageBox.Show("같은 숫자가 있습니다. ");
                return;
            }
            int strike = 0;
            int ball = 0;
            theGame.CheckNumber(num1, num2, num3, ref strike, ref ball);
            statusLabel.Text = String.Format("S:{0}, B:{1}", strike, ball);

            // 게임이 종료되면 축하해준다.
            if (strike == 3)
            {
                MessageBox.Show("전부 맞추었습니다.");
            }

        }
    }
}
