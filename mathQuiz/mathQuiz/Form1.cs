using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathQuiz
{
       public partial class Form1 : Form
    {
        Random randomzier = new Random();

        int addNum1;
        int addNum2;
        int addNum3;
        int addNum4;
        int addNum5;
        int addNum6;
        int addNum7;
        int addNum8;
        int clock;


        public void StartQuiz()
        {
            addNum1 = randomzier.Next(51);
            addNum2 = randomzier.Next(51);

            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();

            sum.Value = 0;

            addNum3 = randomzier.Next(1,10);
            addNum4 = randomzier.Next(1, addNum3);

            minusLeftLabel.Text = addNum3.ToString();
            minusRightabel.Text = addNum4.ToString();

            difference.Value = 0;


            addNum5 = randomzier.Next(2,11);
            addNum6 = randomzier.Next(2,11);

            timesLeftLabel.Text = addNum5.ToString();
            timesRightLabel.Text = addNum6.ToString();

            product.Value = 0;

            addNum8 = randomzier.Next(2,11);
            int temporaryQuotient = randomzier.Next(2, 11);
            addNum7 = addNum8 * temporaryQuotient;

            difisionLeftLabel.Text = addNum7.ToString();
            difisionRightLabel.Text = addNum8.ToString();

            difision.Value = 0;


            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();


        }
           private bool checkAnswer()
        {
            if ((addNum1 + addNum2 == sum.Value)
                && (addNum3 - addNum4 == difference.Value)
                && (addNum5 * addNum6 == product.Value)
                && (addNum7 / addNum8 == difision.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock >0)
            {
                clock = clock - 1;
                timeLabel.Text = clock + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's out!";
                MessageBox.Show("You didn't finish in Time");
                sum.Value = addNum1 + addNum2;
                difference.Value = addNum3 - addNum4;
                product.Value = addNum5 * addNum6;
                difference.Value = addNum7 / addNum8;
                startButton.Enabled = true;
            }
        }

        private void answerEnder(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;


            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
