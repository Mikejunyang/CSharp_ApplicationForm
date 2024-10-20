// Name: Mike Jun Yang Chiu Lim
// Date: 25.07.2023
// Description: Final Project (Section 3)

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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string pathBin = @".\Files\TempConversions.txt";
        FileStream fs = null;

        private void radioCtoF_CheckedChanged(object sender, EventArgs e)
        {
            if(radioCtoF.Checked == true)
            {
                label2.Text = "°C";
                label3.Text = "°F";
            }
            else
            {
                label2.Text = "°F";
                label3.Text = "°C";
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            try
            {
                if (radioCtoF.Checked == true)
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    num2 = (num1 * 1.8) + 32;
                    textBox2.Text = $"{num2}";
                }
                else
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    num2 = (num1 - 32) * 5 / 9;
                    textBox2.Text = $"{num2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "0";
            }

            if (radioCtoF.Checked == true && num1 >= 100)
            {
                textBox3.Text = "Water boils";
            }
            else if (radioCtoF.Checked == true && num1 >= 40)
            {
                textBox3.Text = "Hot Bath";
            }
            else if (radioCtoF.Checked == true && num1 >= 37)
            {
                textBox3.Text = "Body temperature";
            }
            else if (radioCtoF.Checked == true && num1 >= 30)
            {
                textBox3.Text = "Beach temperature";
            }
            else if (radioCtoF.Checked == true && num1 >= 21)
            {
                textBox3.Text = "Room temperature";
            }
            else if (radioCtoF.Checked == true && num1 >= 10)
            {
                textBox3.Text = "Cool Day";
            }
            else if (radioCtoF.Checked == true && num1 >= 0)
            {
                textBox3.Text = "Freezing point of water";
            }
            else if (radioCtoF.Checked == true && num1 >= -18)
            {
                textBox3.Text = "Very Cold Day";
            }
            else if (radioCtoF.Checked == true && num1 >= -40)
            {
                textBox3.Text = "Extremely Cold Day";
            }

            if (radioFtoC.Checked == true && num1 >= 212)
            {
                textBox3.Text = "Water boils";
            }
            else if (radioFtoC.Checked == true && num1 >= 104)
            {
                textBox3.Text = "Hot Bath";
            }
            else if (radioFtoC.Checked == true && num1 >= 98.6)
            {
                textBox3.Text = "Body temperature";
            }
            else if (radioFtoC.Checked == true && num1 >= 86)
            {
                textBox3.Text = "Beach temperature";
            }
            else if (radioFtoC.Checked == true && num1 >= 70)
            {
                textBox3.Text = "Room temperature";
            }
            else if (radioFtoC.Checked == true && num1 >= 50)
            {
                textBox3.Text = "Cool Day";
            }
            else if (radioFtoC.Checked == true && num1 >= 32)
            {
                textBox3.Text = "Freezing point of water";
            }
            else if (radioFtoC.Checked == true && num1 >= 0)
            {
                textBox3.Text = "Very Cold Day";
            }
            else if (radioFtoC.Checked == true && num1 >= -40)
            {
                textBox3.Text = "Extremely Cold Day";
            }

            try
            {
                if (radioCtoF.Checked == true)
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.Write($"{textBox1.Text} C = {textBox2.Text} F, ");
                    textOut.Write(DateTime.Now.ToLongDateString() + " ");
                    textOut.Write(DateTime.Now.ToLongTimeString() + " ");
                    textOut.WriteLine(textBox3.Text);
                    textOut.Close();
                }
                else
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.Write($"{textBox1.Text} F = {textBox2.Text} C, ");
                    textOut.Write(DateTime.Now.ToLongDateString() + " ");
                    textOut.Write(DateTime.Now.ToLongTimeString() + " ");
                    textOut.WriteLine(textBox3.Text);
                    textOut.Close();
                }
                
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (fs != null) fs.Close(); }
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(pathBin, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Temperature Mike Jun Yang Chiu Lim\n";

                while (textIn.Peek() != -1)
                {
                    textToPrint += textIn.ReadLine() + "\n";

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

        private void Temperature_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
