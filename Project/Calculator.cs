// Name: Mike Jun Yang Chiu Lim
// Date: 18.07.2023
// Description: Final Project (Section 2)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Calculator : Form
    {
        decimal firstNumber;
        string Operation;
        public Calculator()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string pathBin = @".\Files\Calculator.txt";
        FileStream fs = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void btn_Substract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x";
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            decimal SecondNumber;
            decimal Result;

            SecondNumber = Convert.ToDecimal(textBox1.Text);

            if (Operation == "+")
            {
                Result = (firstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                textBox1.Text = $"{firstNumber} + {SecondNumber} = {Result}";
                textBox2.Text = textBox2.Text + Result;
                firstNumber = Result;

                try
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(textBox1.Text);
                    textOut.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { if (fs != null) fs.Close(); }
            }
            if (Operation == "-")
            {
                Result = (firstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                textBox1.Text = $"{firstNumber} - {SecondNumber} = {Result}";
                textBox2.Text = textBox2.Text + Result;
                firstNumber = Result;

                try
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(textBox1.Text);
                    textOut.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { if (fs != null) fs.Close(); }
            }
            if (Operation == "x")
            {
                Result = (firstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                textBox1.Text = $"{firstNumber} x {SecondNumber} = {Result}";
                textBox2.Text = textBox2.Text + Result;
                firstNumber = Result;

                try
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(textBox1.Text);
                    textOut.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { if (fs != null) fs.Close(); }
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (firstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    textBox1.Text = $"{firstNumber} / {SecondNumber} = {Result}";
                    textBox2.Text = textBox2.Text + Result;
                    firstNumber = Result;

                    try
                    {
                        fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                        StreamWriter textOut = new StreamWriter(fs);
                        textOut.WriteLine(textBox1.Text);
                        textOut.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { if (fs != null) fs.Close(); }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            try
            {
                fs = new FileStream(pathBin, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Calculation saved!";

                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                }
                MessageBox.Show(textToPrint);

                textIn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occured while reading the file: {ex.Message}", "Error");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning).ToString() == "OK")
            {
                MessageBox.Show("You decide to quit");
                //System.Environment.Exit(0);
                this.Close();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
