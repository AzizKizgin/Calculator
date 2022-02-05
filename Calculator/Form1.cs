using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string NumberText = "";
        private char[] delimiter = { '*', '/', '+', '-' };
        char operation = ' ';
        private double result = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberText += "1";
            screenText.Text = NumberText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberText += "2";
            screenText.Text = NumberText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberText += "3";
            screenText.Text = NumberText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberText += "4";
            screenText.Text = NumberText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberText += "5";
            screenText.Text = NumberText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberText += "6";
            screenText.Text = NumberText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberText += "7";
            screenText.Text = NumberText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberText += "8";
            screenText.Text = NumberText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberText += "9";
            screenText.Text = NumberText;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberText += "0";
            screenText.Text = NumberText;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if(screenText.Text!="" && !screenText.Text.Contains('*') && !screenText.Text.Contains('-') && !screenText.Text.Contains('+') && !screenText.Text.Contains('/'))
            {
                NumberText += "/";
                screenText.Text = NumberText;
                operation = '/';
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (screenText.Text != "" && !screenText.Text.Contains('/') && !screenText.Text.Contains('-') && !screenText.Text.Contains('+') && !screenText.Text.Contains('*'))
            {
                NumberText += "*";
                screenText.Text = NumberText;
                operation = '*';

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (screenText.Text != "" && !screenText.Text.Contains('*') && !screenText.Text.Contains('/') && !screenText.Text.Contains('+') && !screenText.Text.Contains('-'))
            {
                NumberText += "-";
                screenText.Text = NumberText;
                operation = '-';

            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (screenText.Text != "" && !screenText.Text.Contains('*') && !screenText.Text.Contains('-') && !screenText.Text.Contains('/') && !screenText.Text.Contains('+'))
            {
                NumberText += "+";
                screenText.Text = NumberText;
                operation = '+';

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            NumberText = "";
            screenText.Text = NumberText;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (NumberText != "" && !NumberText.EndsWith("*") && !NumberText.EndsWith("-") && !NumberText.EndsWith("+") && !NumberText.EndsWith("/") && !NumberText.StartsWith("+") && !NumberText.StartsWith("-") && !NumberText.StartsWith("*") && !NumberText.StartsWith("/"))
            {

                {
                    string[] nums = NumberText.Split(delimiter);
                    double num1 = Convert.ToDouble(nums[0]);
                    double num2;
                    if (nums.Length == 1)
                    {
                        num2 = 0;
                    }
                    else
                        num2 = Convert.ToDouble(nums[1]);
                    double sum = num1 + num2;
                    double div = num1 / num2;
                    double min = num1 - num2;
                    double mul = num1 * num2;
                    switch (operation)
                    {

                        case '/':
                            screenText.Text = div.ToString();
                            NumberText = screenText.Text;
                            break;
                        case '*':
                            screenText.Text = mul.ToString();
                            NumberText = screenText.Text;
                            break;
                        case '-':
                            screenText.Text = min.ToString();
                            NumberText = screenText.Text;
                            break;
                        case '+':
                            screenText.Text = sum.ToString();
                            NumberText = screenText.Text;
                            break;
                        default:
                            break;
                    }
                }
                
            }
            else
            {
                screenText.Text = "Error";
                NumberText = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sadece uygulamadaki tuşları kullanınız.");
        }
    }
}
