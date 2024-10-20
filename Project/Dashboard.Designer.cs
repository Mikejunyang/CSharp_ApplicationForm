namespace Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_IPValid = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IPValid = new System.Windows.Forms.Button();
            this.tabPage_Calc = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.tabPage_Conv = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TempConv = new System.Windows.Forms.Button();
            this.btn_MoneyConv = new System.Windows.Forms.Button();
            this.tabPage_GenNum = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Lotto649 = new System.Windows.Forms.Button();
            this.btn_LottoMax = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_IPValid.SuspendLayout();
            this.tabPage_Calc.SuspendLayout();
            this.tabPage_Conv.SuspendLayout();
            this.tabPage_GenNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_IPValid);
            this.tabControl1.Controls.Add(this.tabPage_Calc);
            this.tabControl1.Controls.Add(this.tabPage_Conv);
            this.tabControl1.Controls.Add(this.tabPage_GenNum);
            this.tabControl1.Location = new System.Drawing.Point(39, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_IPValid
            // 
            this.tabPage_IPValid.Controls.Add(this.label1);
            this.tabPage_IPValid.Controls.Add(this.btn_IPValid);
            this.tabPage_IPValid.Location = new System.Drawing.Point(4, 25);
            this.tabPage_IPValid.Name = "tabPage_IPValid";
            this.tabPage_IPValid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_IPValid.Size = new System.Drawing.Size(631, 337);
            this.tabPage_IPValid.TabIndex = 0;
            this.tabPage_IPValid.Text = "IPV4 & V6 Validator";
            this.tabPage_IPValid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Validator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_IPValid
            // 
            this.btn_IPValid.Image = global::Project.Properties.Resources.ip4;
            this.btn_IPValid.Location = new System.Drawing.Point(225, 58);
            this.btn_IPValid.Name = "btn_IPValid";
            this.btn_IPValid.Size = new System.Drawing.Size(187, 199);
            this.btn_IPValid.TabIndex = 0;
            this.btn_IPValid.UseVisualStyleBackColor = true;
            this.btn_IPValid.Click += new System.EventHandler(this.btn_IPValid_Click);
            // 
            // tabPage_Calc
            // 
            this.tabPage_Calc.Controls.Add(this.label2);
            this.tabPage_Calc.Controls.Add(this.btn_Calc);
            this.tabPage_Calc.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Calc.Name = "tabPage_Calc";
            this.tabPage_Calc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Calc.Size = new System.Drawing.Size(631, 337);
            this.tabPage_Calc.TabIndex = 1;
            this.tabPage_Calc.Text = "Simple Calculator";
            this.tabPage_Calc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simple Calculator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Image = global::Project.Properties.Resources.Calculator;
            this.btn_Calc.Location = new System.Drawing.Point(230, 79);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(172, 183);
            this.btn_Calc.TabIndex = 0;
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // tabPage_Conv
            // 
            this.tabPage_Conv.Controls.Add(this.label4);
            this.tabPage_Conv.Controls.Add(this.label3);
            this.tabPage_Conv.Controls.Add(this.btn_TempConv);
            this.tabPage_Conv.Controls.Add(this.btn_MoneyConv);
            this.tabPage_Conv.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Conv.Name = "tabPage_Conv";
            this.tabPage_Conv.Size = new System.Drawing.Size(631, 337);
            this.tabPage_Conv.TabIndex = 2;
            this.tabPage_Conv.Text = "Conventions";
            this.tabPage_Conv.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature Convert";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money Exchange";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_TempConv
            // 
            this.btn_TempConv.Image = global::Project.Properties.Resources.tempConvert;
            this.btn_TempConv.Location = new System.Drawing.Point(366, 70);
            this.btn_TempConv.Name = "btn_TempConv";
            this.btn_TempConv.Size = new System.Drawing.Size(163, 164);
            this.btn_TempConv.TabIndex = 1;
            this.btn_TempConv.UseVisualStyleBackColor = true;
            this.btn_TempConv.Click += new System.EventHandler(this.btn_TempConv_Click);
            // 
            // btn_MoneyConv
            // 
            this.btn_MoneyConv.Image = global::Project.Properties.Resources.moneyConvert;
            this.btn_MoneyConv.Location = new System.Drawing.Point(107, 70);
            this.btn_MoneyConv.Name = "btn_MoneyConv";
            this.btn_MoneyConv.Size = new System.Drawing.Size(157, 164);
            this.btn_MoneyConv.TabIndex = 0;
            this.btn_MoneyConv.UseVisualStyleBackColor = true;
            this.btn_MoneyConv.Click += new System.EventHandler(this.btn_MoneyConv_Click);
            // 
            // tabPage_GenNum
            // 
            this.tabPage_GenNum.Controls.Add(this.label6);
            this.tabPage_GenNum.Controls.Add(this.label5);
            this.tabPage_GenNum.Controls.Add(this.btn_Lotto649);
            this.tabPage_GenNum.Controls.Add(this.btn_LottoMax);
            this.tabPage_GenNum.Location = new System.Drawing.Point(4, 25);
            this.tabPage_GenNum.Name = "tabPage_GenNum";
            this.tabPage_GenNum.Size = new System.Drawing.Size(631, 337);
            this.tabPage_GenNum.TabIndex = 3;
            this.tabPage_GenNum.Text = "Generated Numbers";
            this.tabPage_GenNum.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lotto 649";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lotto Max";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_Lotto649
            // 
            this.btn_Lotto649.Image = global::Project.Properties.Resources.Lotto649;
            this.btn_Lotto649.Location = new System.Drawing.Point(380, 64);
            this.btn_Lotto649.Name = "btn_Lotto649";
            this.btn_Lotto649.Size = new System.Drawing.Size(157, 179);
            this.btn_Lotto649.TabIndex = 1;
            this.btn_Lotto649.UseVisualStyleBackColor = true;
            this.btn_Lotto649.Click += new System.EventHandler(this.btn_Lotto649_Click);
            // 
            // btn_LottoMax
            // 
            this.btn_LottoMax.Image = global::Project.Properties.Resources.LottoMax;
            this.btn_LottoMax.Location = new System.Drawing.Point(91, 64);
            this.btn_LottoMax.Name = "btn_LottoMax";
            this.btn_LottoMax.Size = new System.Drawing.Size(167, 179);
            this.btn_LottoMax.TabIndex = 0;
            this.btn_LottoMax.UseVisualStyleBackColor = true;
            this.btn_LottoMax.Click += new System.EventHandler(this.btn_LottoMax_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(588, 403);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(119, 35);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard Mike Jun Yang Chiu Lim";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_IPValid.ResumeLayout(false);
            this.tabPage_IPValid.PerformLayout();
            this.tabPage_Calc.ResumeLayout(false);
            this.tabPage_Calc.PerformLayout();
            this.tabPage_Conv.ResumeLayout(false);
            this.tabPage_Conv.PerformLayout();
            this.tabPage_GenNum.ResumeLayout(false);
            this.tabPage_GenNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_IPValid;
        private System.Windows.Forms.TabPage tabPage_Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IPValid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.TabPage tabPage_Conv;
        private System.Windows.Forms.Button btn_TempConv;
        private System.Windows.Forms.Button btn_MoneyConv;
        private System.Windows.Forms.TabPage tabPage_GenNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Lotto649;
        private System.Windows.Forms.Button btn_LottoMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit;
    }
}

