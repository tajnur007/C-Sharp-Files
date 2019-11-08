namespace Bank_Interest_Calculation
{
    partial class BankInterestCalculation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.totalInterestTexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (In Year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Interest";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "SONALI",
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(146, 44);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(190, 28);
            this.bankNameComboBox.TabIndex = 4;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(146, 82);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(76, 26);
            this.timeTextBox.TabIndex = 5;
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeTextBox_KeyPress);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(146, 122);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(190, 26);
            this.balanceTextBox.TabIndex = 6;
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BalanceTextBox_KeyPress);
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.Location = new System.Drawing.Point(190, 174);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(146, 31);
            this.calculateInterestButton.TabIndex = 7;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = true;
            this.calculateInterestButton.Click += new System.EventHandler(this.CalculateInterestButton_Click);
            // 
            // totalInterestTexBox
            // 
            this.totalInterestTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestTexBox.Location = new System.Drawing.Point(145, 228);
            this.totalInterestTexBox.Name = "totalInterestTexBox";
            this.totalInterestTexBox.ReadOnly = true;
            this.totalInterestTexBox.Size = new System.Drawing.Size(191, 26);
            this.totalInterestTexBox.TabIndex = 8;
            // 
            // BankInterestCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 292);
            this.Controls.Add(this.totalInterestTexBox);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankInterestCalculation";
            this.Text = "Bank Interest Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.TextBox totalInterestTexBox;
    }
}

