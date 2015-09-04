namespace Checks
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCheckPayTo = new System.Windows.Forms.TextBox();
            this.txtCheckMemo = new System.Windows.Forms.TextBox();
            this.txtCheckAmtString = new System.Windows.Forms.TextBox();
            this.txtCheckAmount = new System.Windows.Forms.TextBox();
            this.txtCheckNum = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTallyCheck = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTallyAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1507, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPayTo
            // 
            this.txtPayTo.Location = new System.Drawing.Point(1624, 14);
            this.txtPayTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPayTo.Name = "txtPayTo";
            this.txtPayTo.Size = new System.Drawing.Size(260, 38);
            this.txtPayTo.TabIndex = 1;
            this.txtPayTo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1504, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(1624, 88);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(260, 38);
            this.txtMemo.TabIndex = 3;
            this.txtMemo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1475, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "$ (Num.)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1624, 165);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 38);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1619, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCheckPayTo
            // 
            this.txtCheckPayTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.txtCheckPayTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckPayTo.Location = new System.Drawing.Point(405, 155);
            this.txtCheckPayTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCheckPayTo.Name = "txtCheckPayTo";
            this.txtCheckPayTo.Size = new System.Drawing.Size(267, 31);
            this.txtCheckPayTo.TabIndex = 7;
            this.txtCheckPayTo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCheckMemo
            // 
            this.txtCheckMemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.txtCheckMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckMemo.Location = new System.Drawing.Point(205, 308);
            this.txtCheckMemo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCheckMemo.Name = "txtCheckMemo";
            this.txtCheckMemo.Size = new System.Drawing.Size(267, 31);
            this.txtCheckMemo.TabIndex = 10;
            // 
            // txtCheckAmtString
            // 
            this.txtCheckAmtString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.txtCheckAmtString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckAmtString.Location = new System.Drawing.Point(75, 203);
            this.txtCheckAmtString.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCheckAmtString.Name = "txtCheckAmtString";
            this.txtCheckAmtString.Size = new System.Drawing.Size(1248, 31);
            this.txtCheckAmtString.TabIndex = 11;
            this.txtCheckAmtString.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtCheckAmount
            // 
            this.txtCheckAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckAmount.Location = new System.Drawing.Point(944, 157);
            this.txtCheckAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCheckAmount.Name = "txtCheckAmount";
            this.txtCheckAmount.Size = new System.Drawing.Size(267, 31);
            this.txtCheckAmount.TabIndex = 12;
            this.txtCheckAmount.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtCheckNum
            // 
            this.txtCheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.txtCheckNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckNum.ForeColor = System.Drawing.Color.Black;
            this.txtCheckNum.Location = new System.Drawing.Point(640, 408);
            this.txtCheckNum.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCheckNum.Name = "txtCheckNum";
            this.txtCheckNum.Size = new System.Drawing.Size(267, 31);
            this.txtCheckNum.TabIndex = 13;
            this.txtCheckNum.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(1056, 88);
            this.txtDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(267, 31);
            this.txtDate.TabIndex = 14;
            this.txtDate.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Checks Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTallyCheck
            // 
            this.txtTallyCheck.Location = new System.Drawing.Point(309, 513);
            this.txtTallyCheck.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTallyCheck.Name = "txtTallyCheck";
            this.txtTallyCheck.Size = new System.Drawing.Size(260, 38);
            this.txtTallyCheck.TabIndex = 16;
            this.txtTallyCheck.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 520);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Amount: ";
            // 
            // txtTallyAmount
            // 
            this.txtTallyAmount.Location = new System.Drawing.Point(797, 513);
            this.txtTallyAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTallyAmount.Name = "txtTallyAmount";
            this.txtTallyAmount.Size = new System.Drawing.Size(260, 38);
            this.txtTallyAmount.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1923, 594);
            this.Controls.Add(this.txtTallyAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTallyCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCheckNum);
            this.Controls.Add(this.txtCheckAmount);
            this.Controls.Add(this.txtCheckAmtString);
            this.Controls.Add(this.txtCheckMemo);
            this.Controls.Add(this.txtCheckPayTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPayTo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCheckPayTo;
        private System.Windows.Forms.TextBox txtCheckMemo;
        private System.Windows.Forms.TextBox txtCheckAmtString;
        private System.Windows.Forms.TextBox txtCheckAmount;
        private System.Windows.Forms.TextBox txtCheckNum;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTallyCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTallyAmount;
    }
}

