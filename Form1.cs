using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Integers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Integer Logic
        private void btnIntegers_Click(object sender, EventArgs e)
        {
            int myIntegers;
            int int1;
            int int2;

            int1 = 15;
            int2 = 20;
            myIntegers = int1 + int2;
            MessageBox.Show(myIntegers.ToString(), "My Integer", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            MessageBox.Show("Check me Integer Skills", "SKILZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Float Logic
        private void btnFloat_Click(object sender, EventArgs e)
        {
            float myFloat;
            float float1;
            float float2;

            float1 = 0.45f;
            float2 = 0.35f;

            myFloat = float1 + float2;
            MessageBox.Show(myFloat.ToString(), "My Float", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            MessageBox.Show("Check My Float Skills", "My Float", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        //Double Logic
        private void btnDouble_Click(object sender, EventArgs e)
        {
            Double myDouble;
            Double double1;
            Double double2;

            double1 = 0.008;
            double2 = 0.009;

            myDouble = double1 + double2;

            MessageBox.Show(myDouble.ToString(), "My Double", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            MessageBox.Show("Check Double Skills", "My Double", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdNumber = 50;

            answer = firstNumber + secondNumber + thirdNumber;

            MessageBox.Show(answer.ToString(), "Addition Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Check these Addition Skills", "Addition Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 25;
            thirdNumber = 35;

            answer = firstNumber - secondNumber - thirdNumber;

            MessageBox.Show(answer.ToString(), "Subtraction Logic", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            MessageBox.Show("Check my subtraction Skills", "Subtraction Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdnumber;
            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdnumber = 50;

            answer = firstNumber + secondNumber - thirdnumber;

            MessageBox.Show(answer.ToString(), "Mixed Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Check My Mixed Skills", "Mixed Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);          
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 5;
            secondNumber = 10;
            thirdNumber = 2;

            answer = firstNumber * secondNumber * thirdNumber;

            MessageBox.Show(answer.ToString(), "Multiplication Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Check out these Skills", "Multiplication Logic", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDevision_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 10;
            thirdNumber = 2;

            answer = firstNumber / secondNumber / thirdNumber;

            MessageBox.Show(answer.ToString(), "Devision Logic", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            MessageBox.Show("Check Out this Devision", "Devison Logic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdNumber = 50;

            answer = (firstNumber * secondNumber) / thirdNumber;

            MessageBox.Show(answer.ToString(), "Exercise 1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            MessageBox.Show("Check out Exercise 1 completed", "Exercise 1", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 75;
            thirdNumber = 50;

            answer = firstNumber * (secondNumber / thirdNumber);

            MessageBox.Show(answer.ToString(), "Exercise 2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            MessageBox.Show("Check out Exercise 2 completed", "Exercise 2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
