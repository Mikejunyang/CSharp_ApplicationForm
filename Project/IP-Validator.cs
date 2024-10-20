// Name: Mike Jun Yang Chiu Lim
// Date: 11.07.2023
// Description: Final Project (Section 1)

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
using System.IO;
using System.IO.Pipes;

namespace Project
{
    
    public partial class IP_Validator : Form
    {

        public IP_Validator()
        {
            InitializeComponent();
        }

        static string dir = @".\Files\";
        string pathBin = @".\Files\ipv4ipv6Bin.txt";
        FileStream fs = null;
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string ipv4;
        string ipv6;
        
        private void btn_ValidIP_Click(object sender, EventArgs e)
        {
            
            Regex obj;

            obj = new Regex(@"^\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b$");
            if (obj.IsMatch(textBox1.Text) == true)
            {
                ipv4 = textBox1.Text;
                MessageBox.Show($"{textBox1.Text}\nThe IP is correct", "Valid IP");

                try
                {
                    fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(ipv4);
                    bw.Write(DateTime.Now.ToString("dd/MM/yyyy H:mm:ss tt"));
                    bw.Close();
                }
                catch (IOException ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
                finally { if (fs != null) fs.Close(); }

                obj = new Regex(@"^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$");
                if (obj.IsMatch(textBox2.Text) == true)
                {
                    ipv6 = textBox2.Text;
                    MessageBox.Show($"{textBox2.Text}\nThe IP is correct", "Valid IP");
                    try
                    {
                        fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(ipv6);
                        bw.Write(DateTime.Now.ToString("dd/MM/yyyy H:mm:ss tt"));
                        bw.Close();
                    }
                    catch (IOException ex1)
                    {
                        MessageBox.Show(ex1.Message);
                    }
                    finally { if (fs != null) fs.Close(); }
                }
                else
                {
                    MessageBox.Show($"{textBox2.Text}\nThe IP must have 16 bytes\nhexadecimal between 0 to f[F]\nseperated by a dot (2001:0db8:0000:0000:0000:8a2e:0370:7334)", "Error");
                }
            }
            else
            {
                MessageBox.Show($"{textBox1.Text}\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseperated by a dot (255.255.255.255)", "Error");
            }


        }

        private void btn_ReadandDisplay_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"IPV4 address entered: {ipv4}\n\nIPV6 address entered: {ipv6}");

            try
            {
                using (FileStream fileStream = new FileStream(pathBin, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader bR = new BinaryReader(fileStream))
                    {
                        string textToPrint = "";
                        while (bR.PeekChar() != -1)
                        {
                            string IPContent = bR.ReadString();
                            string IPDate = bR.ReadString();
                            textToPrint += IPContent + " " + IPDate + "\n";
                        }
                        MessageBox.Show(textToPrint);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occured while reading the file: {ex.Message}", "Error");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
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

        private void IP_Validator_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            label2.Text = d.ToLongDateString();

            if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        }
    }
}
