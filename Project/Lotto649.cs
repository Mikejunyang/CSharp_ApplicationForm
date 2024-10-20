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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string pathBin = @".\Files\LottoNbrs.txt";
        FileStream fs = null;

        private void btn_GenerateNum_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string newline = Environment.NewLine;
            int randomNumber1;//= random.Next(1, 49);
            int randomNumber2;//= random.Next(0, 9);
            int[] nbrs = new int[7];

            //textBox1.Text = randomNumber1.ToString();
            //textBox2.Text = randomNumber2.ToString();   

            for (int i = 0; i <= 6; i++)
            {
                randomNumber1 = random.Next(1, 49);
                textBox1.Text = textBox1.Text + newline + randomNumber1.ToString();
                nbrs[i] = randomNumber1;
            }

            for (int i = 0; i <= 6; i++)
            {
                randomNumber2 = random.Next(0, 9);
                textBox2.Text = textBox2.Text + randomNumber2.ToString();
            }

            try
            {
                fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.Write("649, ");
                textOut.Write(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + ", ");
                for (int i = 0; i < 6; i++)
                {
                    textOut.Write(nbrs[i] + ",");
                }
                textOut.Write(" Bonus " + nbrs[6]);// nbrs.Length-1]);
                textOut.WriteLine(" Extra " + textBox2.Text);
                textOut.Close();
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
                string textToPrint = "Lotto649 Mike Jun Yang Chiu Lim\n";

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

        private void Lotto649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
