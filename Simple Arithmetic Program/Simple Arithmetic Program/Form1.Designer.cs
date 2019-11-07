namespace Simple_Arithmetic_Program
{
    partial class SimpleArithmeticProgram
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultViewLabel = new System.Windows.Forms.Label();
            this.hintsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLabel.Location = new System.Drawing.Point(36, 65);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberLabel.Location = new System.Drawing.Point(36, 108);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(124, 20);
            this.secondNumberLabel.TabIndex = 0;
            this.secondNumberLabel.Text = "Second Number";
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberTextBox.Location = new System.Drawing.Point(166, 108);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(156, 26);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.TextChanged += new System.EventHandler(this.SecondNumberTextBox_TextChanged);
            this.secondNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNumberTextBox_KeyPress);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberTextBox.Location = new System.Drawing.Point(166, 65);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(156, 26);
            this.firstNumberTextBox.TabIndex = 1;
            this.firstNumberTextBox.TextChanged += new System.EventHandler(this.FirstNumberTextBox_TextChanged);
            this.firstNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNumberTextBox_KeyPress);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(40, 144);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(33, 34);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(89, 144);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(33, 34);
            this.minusButton.TabIndex = 2;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(138, 144);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(33, 34);
            this.multiplicationButton.TabIndex = 2;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(188, 144);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(33, 34);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(252, 144);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 34);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // resultViewLabel
            // 
            this.resultViewLabel.AutoSize = true;
            this.resultViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultViewLabel.Location = new System.Drawing.Point(35, 201);
            this.resultViewLabel.Name = "resultViewLabel";
            this.resultViewLabel.Size = new System.Drawing.Size(282, 25);
            this.resultViewLabel.TabIndex = 4;
            this.resultViewLabel.Text = "                                             ";
            this.resultViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hintsLabel
            // 
            this.hintsLabel.AutoSize = true;
            this.hintsLabel.Location = new System.Drawing.Point(115, 31);
            this.hintsLabel.Name = "hintsLabel";
            this.hintsLabel.Size = new System.Drawing.Size(144, 13);
            this.hintsLabel.TabIndex = 5;
            this.hintsLabel.Text = "*Hints: Enter the first number.";
            this.hintsLabel.Click += new System.EventHandler(this.HintsLabel_Click);
            // 
            // SimpleArithmeticProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 314);
            this.Controls.Add(this.hintsLabel);
            this.Controls.Add(this.resultViewLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "SimpleArithmeticProgram";
            this.Text = "Simple Arithmetic Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultViewLabel;
        private System.Windows.Forms.Label hintsLabel;
    }
}

