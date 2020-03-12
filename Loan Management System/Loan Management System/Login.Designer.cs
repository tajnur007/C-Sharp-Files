namespace Loan_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.forgoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.loginUserNameLabel = new System.Windows.Forms.Label();
            this.loginLabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.loginGroupBox.Controls.Add(this.forgoLinkLabel);
            this.loginGroupBox.Controls.Add(this.createAccountButton);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.loginPasswordLabel);
            this.loginGroupBox.Controls.Add(this.userNameTextBox);
            this.loginGroupBox.Controls.Add(this.loginUserNameLabel);
            this.loginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupBox.Location = new System.Drawing.Point(482, 231);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(439, 276);
            this.loginGroupBox.TabIndex = 2;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "User Login";
            // 
            // forgoLinkLabel
            // 
            this.forgoLinkLabel.AutoSize = true;
            this.forgoLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgoLinkLabel.LinkColor = System.Drawing.Color.Lime;
            this.forgoLinkLabel.Location = new System.Drawing.Point(26, 183);
            this.forgoLinkLabel.Name = "forgoLinkLabel";
            this.forgoLinkLabel.Size = new System.Drawing.Size(208, 17);
            this.forgoLinkLabel.TabIndex = 6;
            this.forgoLinkLabel.TabStop = true;
            this.forgoLinkLabel.Text = "Forgot Username or Password?";
            this.forgoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgoLinkLabel_LinkClicked);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createAccountButton.Location = new System.Drawing.Point(20, 219);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(390, 37);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create An Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(290, 170);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 37);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(132, 108);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(278, 30);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginPasswordLabel.Location = new System.Drawing.Point(24, 111);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(114, 25);
            this.loginPasswordLabel.TabIndex = 4;
            this.loginPasswordLabel.Text = "Password : ";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(132, 54);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(278, 30);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // loginUserNameLabel
            // 
            this.loginUserNameLabel.AutoSize = true;
            this.loginUserNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginUserNameLabel.Location = new System.Drawing.Point(19, 57);
            this.loginUserNameLabel.Name = "loginUserNameLabel";
            this.loginUserNameLabel.Size = new System.Drawing.Size(118, 25);
            this.loginUserNameLabel.TabIndex = 3;
            this.loginUserNameLabel.Text = "Username : ";
            // 
            // loginLabel3
            // 
            this.loginLabel3.AutoSize = true;
            this.loginLabel3.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel3.Font = new System.Drawing.Font("Lazenby Computer", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.loginLabel3.Location = new System.Drawing.Point(304, 70);
            this.loginLabel3.Name = "loginLabel3";
            this.loginLabel3.Size = new System.Drawing.Size(346, 65);
            this.loginLabel3.TabIndex = 1;
            this.loginLabel3.Text = "Welcome To";
            this.loginLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lazenby Computer", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(112, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOAN MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.loginLabel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login - Loan Management System";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label loginUserNameLabel;
        private System.Windows.Forms.Label loginLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgoLinkLabel;
        private System.Windows.Forms.Button createAccountButton;
    }
}

