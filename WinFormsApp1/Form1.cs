using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homwork1Lib;

namespace WinFormsApp1
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonTask1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible=true;
            groupBoxTask2.Visible = false;
            groupBoxTask3.Visible = false;
            groupBoxTask4.Visible = false;
            groupBoxTask5.Visible = false;
            groupBoxCalculator.Visible = false;
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            textBoxTask1.Visible = true;
            double result;
            result = Homework1.Task1(Convert.ToInt32(numericUpDown1A.Value), Convert.ToInt32(numericUpDown1B.Value));
            textBoxTask1.Text= "Result = " + Convert.ToString(result);
        }

        private void radioButtonTask2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible = false;
            groupBoxTask2.Visible = true;
            groupBoxTask3.Visible = false;
            groupBoxTask4.Visible = false;
            groupBoxTask5.Visible = false;
            groupBoxCalculator.Visible = false;
        }

        private void buttonTask2_Click_1(object sender, EventArgs e)
        {
            textBox2ARes.Visible = true;
            textBox2BRes.Visible = true;
            label2ARes.Visible = true;
            label2BRes.Visible = true;
            string a = textBox2A.Text;
            string b = textBox2B.Text;
            Homework1.Task2(ref a, ref b);
            textBox2ARes.Text = a;
            textBox2BRes.Text = b;
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            textBoxTask3.Visible = true;
            (int division, int remainder) = Homework1.Task3(Convert.ToInt32(numericUpDown3A.Value),
                Convert.ToInt32(numericUpDown3B.Value));
            textBoxTask3.Text = "Division result = " + Convert.ToString(division) + Environment.NewLine +
                "Remainder result = " + Convert.ToString(remainder);
        }

        private void radioButtonTask3_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible = false;
            groupBoxTask2.Visible = false;
            groupBoxTask3.Visible = true;
            groupBoxTask4.Visible = false;
            groupBoxTask5.Visible = false;
            groupBoxCalculator.Visible = false;
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            textBoxTask4.Visible = true;
            double result;
            result = Homework1.Task4(Convert.ToDouble(numericUpDown4A.Value), Convert.ToDouble(numericUpDown4B.Value), Convert.ToDouble(numericUpDown4C.Value));
            textBoxTask4.Text = "Result = " + Convert.ToString(result);
        }

        private void radioButtonTask4_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible = false;
            groupBoxTask2.Visible = false;
            groupBoxTask3.Visible = false;
            groupBoxTask4.Visible = true;
            groupBoxTask5.Visible = false;
            groupBoxCalculator.Visible = false;
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            textBoxTask5.Visible = true;
            (double A, double B) = Homework1.Task5(Convert.ToDouble(numericUpDown5X1.Value),
                Convert.ToDouble(numericUpDown5Y1.Value), Convert.ToDouble(numericUpDown5X2.Value),
                Convert.ToDouble(numericUpDown5Y2.Value));
            textBoxTask5.Text = "A = " + Convert.ToString(A) + Environment.NewLine +
                "B result = " + Convert.ToString(B) + Environment.NewLine +
                "Formula: Y= " + A + "* X + " + B;
        }

        private void radioButtonTask5_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible = false;
            groupBoxTask2.Visible = false;
            groupBoxTask3.Visible = false;
            groupBoxTask4.Visible = false;
            groupBoxTask5.Visible = true;
            groupBoxCalculator.Visible = false;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            if (comboBoxSigner.SelectedIndex == 0)
            {
                textBoxCalculator.Visible = true;
                textBoxCalculator.Text = Convert.ToString(numericUpDownFirstNumber.Value + numericUpDownSecondNumber.Value);
            }
            if (comboBoxSigner.SelectedIndex == 1)
            {
                textBoxCalculator.Visible = true;
                textBoxCalculator.Text = Convert.ToString(numericUpDownFirstNumber.Value - numericUpDownSecondNumber.Value);
            }
            if (comboBoxSigner.SelectedIndex == 2)
            {
                textBoxCalculator.Visible = true;
                textBoxCalculator.Text = Convert.ToString(numericUpDownFirstNumber.Value * numericUpDownSecondNumber.Value);
            }
            if (comboBoxSigner.SelectedIndex == 3)
            {
                textBoxCalculator.Visible = true;
                textBoxCalculator.Text = Convert.ToString(numericUpDownFirstNumber.Value / numericUpDownSecondNumber.Value);
            }
            if (comboBoxSigner.SelectedIndex == 4)
            {
                textBoxCalculator.Visible = true;
                textBoxCalculator.Text = Convert.ToString(numericUpDownFirstNumber.Value % numericUpDownSecondNumber.Value);
            }
        }

        private void radioButtonCalculator_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTask1.Visible = false;
            groupBoxTask2.Visible = false;
            groupBoxTask3.Visible = false;
            groupBoxTask4.Visible = false;
            groupBoxTask5.Visible = false;
            groupBoxCalculator.Visible = true;
        }


    }
}
