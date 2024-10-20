// Name: Mike Jun Yang Chiu Lim
// Date: 11.07.2023
// Description: Final Project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_IPValid_Click(object sender, EventArgs e)
        {
            IP_Validator obj = new IP_Validator();
            //obj.Show();
            obj.ShowDialog();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.ShowDialog();
        }

        private void btn_MoneyConv_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.ShowDialog();
        }

        private void btn_TempConv_Click(object sender, EventArgs e)
        {
            Temperature obj = new Temperature();
            obj.ShowDialog();
        }

        private void btn_LottoMax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();
        }

        private void btn_Lotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
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
    }
}
