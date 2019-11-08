namespace Electricity_Bill_Calculation
{
    partial class ElectricityBillCalculation
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
            this.connectionTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.industrialRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.kwhUsedGroupBox = new System.Windows.Forms.GroupBox();
            this.offPeakHourTextBox = new System.Windows.Forms.TextBox();
            this.peakHourTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateBillButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBillTextBox = new System.Windows.Forms.TextBox();
            this.connectionTypeGroupBox.SuspendLayout();
            this.kwhUsedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionTypeGroupBox
            // 
            this.connectionTypeGroupBox.Controls.Add(this.industrialRadioButton);
            this.connectionTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.connectionTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.connectionTypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionTypeGroupBox.Location = new System.Drawing.Point(56, 63);
            this.connectionTypeGroupBox.Name = "connectionTypeGroupBox";
            this.connectionTypeGroupBox.Size = new System.Drawing.Size(269, 185);
            this.connectionTypeGroupBox.TabIndex = 0;
            this.connectionTypeGroupBox.TabStop = false;
            this.connectionTypeGroupBox.Text = "Connection Type";
            // 
            // industrialRadioButton
            // 
            this.industrialRadioButton.AutoSize = true;
            this.industrialRadioButton.Location = new System.Drawing.Point(39, 126);
            this.industrialRadioButton.Name = "industrialRadioButton";
            this.industrialRadioButton.Size = new System.Drawing.Size(92, 24);
            this.industrialRadioButton.TabIndex = 2;
            this.industrialRadioButton.TabStop = true;
            this.industrialRadioButton.Text = "Industrial";
            this.industrialRadioButton.UseVisualStyleBackColor = true;
            this.industrialRadioButton.CheckedChanged += new System.EventHandler(this.IndustrialRadioButton_CheckedChanged);
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(39, 86);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(110, 24);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.TabStop = true;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            this.commercialRadioButton.CheckedChanged += new System.EventHandler(this.CommercialRadioButton_CheckedChanged);
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(39, 46);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(106, 24);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.ResidentialRadioButton_CheckedChanged);
            // 
            // kwhUsedGroupBox
            // 
            this.kwhUsedGroupBox.Controls.Add(this.offPeakHourTextBox);
            this.kwhUsedGroupBox.Controls.Add(this.peakHourTextBox);
            this.kwhUsedGroupBox.Controls.Add(this.label2);
            this.kwhUsedGroupBox.Controls.Add(this.label1);
            this.kwhUsedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwhUsedGroupBox.Location = new System.Drawing.Point(357, 63);
            this.kwhUsedGroupBox.Name = "kwhUsedGroupBox";
            this.kwhUsedGroupBox.Size = new System.Drawing.Size(295, 185);
            this.kwhUsedGroupBox.TabIndex = 1;
            this.kwhUsedGroupBox.TabStop = false;
            this.kwhUsedGroupBox.Text = "KWH Used";
            // 
            // offPeakHourTextBox
            // 
            this.offPeakHourTextBox.Location = new System.Drawing.Point(135, 105);
            this.offPeakHourTextBox.Name = "offPeakHourTextBox";
            this.offPeakHourTextBox.Size = new System.Drawing.Size(142, 26);
            this.offPeakHourTextBox.TabIndex = 3;
            this.offPeakHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OffPeakHourTextBox_KeyPress);
            // 
            // peakHourTextBox
            // 
            this.peakHourTextBox.Location = new System.Drawing.Point(135, 61);
            this.peakHourTextBox.Name = "peakHourTextBox";
            this.peakHourTextBox.Size = new System.Drawing.Size(142, 26);
            this.peakHourTextBox.TabIndex = 2;
            this.peakHourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeakHourTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Off-Peak Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peak Hour";
            // 
            // calculateBillButton
            // 
            this.calculateBillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBillButton.Location = new System.Drawing.Point(357, 277);
            this.calculateBillButton.Name = "calculateBillButton";
            this.calculateBillButton.Size = new System.Drawing.Size(124, 30);
            this.calculateBillButton.TabIndex = 2;
            this.calculateBillButton.Text = "Calculate Bill";
            this.calculateBillButton.UseVisualStyleBackColor = true;
            this.calculateBillButton.Click += new System.EventHandler(this.CalculateBillButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Bill:";
            // 
            // totalBillTextBox
            // 
            this.totalBillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillTextBox.Location = new System.Drawing.Point(180, 279);
            this.totalBillTextBox.Name = "totalBillTextBox";
            this.totalBillTextBox.ReadOnly = true;
            this.totalBillTextBox.Size = new System.Drawing.Size(145, 26);
            this.totalBillTextBox.TabIndex = 4;
            // 
            // ElectricityBillCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 353);
            this.Controls.Add(this.totalBillTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateBillButton);
            this.Controls.Add(this.kwhUsedGroupBox);
            this.Controls.Add(this.connectionTypeGroupBox);
            this.Name = "ElectricityBillCalculation";
            this.Text = "Electricity Bill Calculation";
            this.connectionTypeGroupBox.ResumeLayout(false);
            this.connectionTypeGroupBox.PerformLayout();
            this.kwhUsedGroupBox.ResumeLayout(false);
            this.kwhUsedGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionTypeGroupBox;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.RadioButton industrialRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.GroupBox kwhUsedGroupBox;
        private System.Windows.Forms.TextBox offPeakHourTextBox;
        private System.Windows.Forms.TextBox peakHourTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBillButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalBillTextBox;
    }
}

