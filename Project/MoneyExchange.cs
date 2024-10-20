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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MoneyExchange : Form
    {
        DateTime opened;
        public MoneyExchange()
        {
            InitializeComponent();
            opened = DateTime.Now;
        }

        static string dir = @".\Files\";
        string pathBin = @".\Files\MoneyConversions.txt";
        FileStream fs = null;

        private void radioCAD_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void radioUSD_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void radioEUR_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void radioGBP_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void radioMRU_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double currency = 0;
            double currencyCAD = 0;
            double currencyUSD = 0;
            double currencyEUR = 0;
            double currencyGBP = 0;
            double currencyMRU = 0;
            double currencyDKK = 0;

            try
            {
                if (radioCAD.Checked == true)
                {
                    currency = Convert.ToDouble(textBox1.Text);
                    currencyCAD = currency;
                    currencyUSD = currency * 0.76;
                    currencyEUR = currency * 0.68;
                    currencyGBP = currency * 0.59;
                    currencyMRU = currency * 34.69;
                    currencyDKK = currency * 5.06;
                    textBox2.Text = $"{currencyCAD}";
                    textBox3.Text = $"{currencyUSD}";
                    textBox4.Text = $"{currencyEUR}";
                    textBox5.Text = $"{currencyGBP}";
                    textBox6.Text = $"{currencyMRU}";
                    textBox7.Text = $"{currencyDKK}";
                }
                else if (radioUSD.Checked == true)
                {
                    currency = Convert.ToDouble(textBox1.Text);
                    currencyCAD = currency * 1.32;
                    currencyUSD = currency;
                    currencyEUR = currency * 0.90;
                    currencyGBP = currency * 0.78;
                    currencyMRU = currency * 45.89;
                    currencyDKK = currency * 6.70;
                    textBox2.Text = $"{currencyCAD}";
                    textBox3.Text = $"{currencyUSD}";
                    textBox4.Text = $"{currencyEUR}";
                    textBox5.Text = $"{currencyGBP}";
                    textBox6.Text = $"{currencyMRU}";
                    textBox7.Text = $"{currencyDKK}";
                }
                else if (radioEUR.Checked == true)
                {
                    currency = Convert.ToDouble(textBox1.Text);
                    currencyCAD = currency * 1.47;
                    currencyUSD = currency * 1.11;
                    currencyEUR = currency;
                    currencyGBP = currency * 0.87;
                    currencyMRU = currency * 51.07;
                    currencyDKK = currency * 7.45;
                    textBox2.Text = $"{currencyCAD}";
                    textBox3.Text = $"{currencyUSD}";
                    textBox4.Text = $"{currencyEUR}";
                    textBox5.Text = $"{currencyGBP}";
                    textBox6.Text = $"{currencyMRU}";
                    textBox7.Text = $"{currencyDKK}";
                }
                else if (radioGBP.Checked == true)
                {
                    currency = Convert.ToDouble(textBox1.Text);
                    currencyCAD = currency * 1.70;
                    currencyUSD = currency * 1.29;
                    currencyEUR = currency * 1.15;
                    currencyGBP = currency;
                    currencyMRU = currency * 59.00;
                    currencyDKK = currency * 8.61;
                    textBox2.Text = $"{currencyCAD}";
                    textBox3.Text = $"{currencyUSD}";
                    textBox4.Text = $"{currencyEUR}";
                    textBox5.Text = $"{currencyGBP}";
                    textBox6.Text = $"{currencyMRU}";
                    textBox7.Text = $"{currencyDKK}";
                }
                else
                {
                    currency = Convert.ToDouble(textBox1.Text);
                    currencyCAD = currency * 0.029;
                    currencyUSD = currency * 0.022;
                    currencyEUR = currency * 0.020;
                    currencyGBP = currency * 0.017;
                    currencyMRU = currency;
                    currencyDKK = currency * 0.15;
                    textBox2.Text = $"{currencyCAD}";
                    textBox3.Text = $"{currencyUSD}";
                    textBox4.Text = $"{currencyEUR}";
                    textBox5.Text = $"{currencyGBP}";
                    textBox6.Text = $"{currencyMRU}";
                    textBox7.Text = $"{currencyDKK}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "0";
            }

            try
            {
                if (radioCAD.Checked == true)
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                    textOut.Write($"{textBox1.Text} CAD = {textBox2.Text} CAD; ");
                    textOut.Write($"{textBox3.Text} USD; ");
                    textOut.Write($"{textBox4.Text} EUR; ");
                    textOut.Write($"{textBox5.Text} GBP; ");
                    textOut.Write($"{textBox6.Text} MUR; ");
                    textOut.WriteLine($"{textBox7.Text} DKK");
                    textOut.Close();
                }
                else if (radioUSD.Checked == true)
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                    textOut.Write($"{textBox1.Text} USD = {textBox2.Text} CAD; ");
                    textOut.Write($"{textBox3.Text} USD; ");
                    textOut.Write($"{textBox4.Text} EUR; ");
                    textOut.Write($"{textBox5.Text} GBP; ");
                    textOut.Write($"{textBox6.Text} MUR; ");
                    textOut.WriteLine($"{textBox7.Text} DKK");
                    textOut.Close();
                }
                else if (radioEUR.Checked == true)
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                    textOut.Write($"{textBox1.Text} EUR = {textBox2.Text} CAD; ");
                    textOut.Write($"{textBox3.Text} USD; ");
                    textOut.Write($"{textBox4.Text} EUR; ");
                    textOut.Write($"{textBox5.Text} GBP; ");
                    textOut.Write($"{textBox6.Text} MUR; ");
                    textOut.WriteLine($"{textBox7.Text} DKK");
                    textOut.Close();
                }
                else if (radioGBP.Checked == true)
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                    textOut.Write($"{textBox1.Text} GBP = {textBox2.Text} CAD; ");
                    textOut.Write($"{textBox3.Text} USD; ");
                    textOut.Write($"{textBox4.Text} EUR; ");
                    textOut.Write($"{textBox5.Text} GBP; ");
                    textOut.Write($"{textBox6.Text} MUR; ");
                    textOut.WriteLine($"{textBox7.Text} DKK");
                    textOut.Close();
                }
                else
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine(DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                    textOut.Write($"{textBox1.Text} MUR = {textBox2.Text} CAD; ");
                    textOut.Write($"{textBox3.Text} USD; ");
                    textOut.Write($"{textBox4.Text} EUR; ");
                    textOut.Write($"{textBox5.Text} GBP; ");
                    textOut.Write($"{textBox6.Text} MUR; ");
                    textOut.WriteLine($"{textBox7.Text} DKK");
                    textOut.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (fs != null) fs.Close(); }
        }

        private void btn_ReadandDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(pathBin, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "MoneyExchange Mike Jun Yang Chiu Lim\n";

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
            DateTime now = DateTime.Now;
            TimeSpan timeSpent = now.Subtract(opened);

            string minutes = Math.Floor(timeSpent.TotalMinutes).ToString();
            string seconds = timeSpent.Seconds.ToString();

            if (MessageBox.Show($"You want to quit? You have been here {minutes} minutes {seconds} seconds.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning).ToString() == "OK")
            {
                MessageBox.Show("You decide to quit");
                //System.Environment.Exit(0);
                this.Close();
            }
        }

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
