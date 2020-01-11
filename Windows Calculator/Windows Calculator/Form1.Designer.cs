namespace Windows_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bigDisplay = new System.Windows.Forms.Label();
            this.smallDisplay = new System.Windows.Forms.Label();
            this.memoryButton = new System.Windows.Forms.Button();
            this.memoryStoreButton = new System.Windows.Forms.Button();
            this.memoryMinusButton = new System.Windows.Forms.Button();
            this.memoryPlusButton = new System.Windows.Forms.Button();
            this.memoryReadButton = new System.Windows.Forms.Button();
            this.memoryClearButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.oneByXButton = new System.Windows.Forms.Button();
            this.xSquareButton = new System.Windows.Forms.Button();
            this.rootXButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bigDisplay
            // 
            this.bigDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigDisplay.Location = new System.Drawing.Point(10, 61);
            this.bigDisplay.Name = "bigDisplay";
            this.bigDisplay.Size = new System.Drawing.Size(365, 42);
            this.bigDisplay.TabIndex = 0;
            this.bigDisplay.Text = "0";
            this.bigDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smallDisplay
            // 
            this.smallDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smallDisplay.Location = new System.Drawing.Point(10, 17);
            this.smallDisplay.Name = "smallDisplay";
            this.smallDisplay.Size = new System.Drawing.Size(365, 31);
            this.smallDisplay.TabIndex = 1;
            this.smallDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryButton
            // 
            this.memoryButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryButton.Enabled = false;
            this.memoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.memoryButton.FlatAppearance.BorderSize = 0;
            this.memoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryButton.Location = new System.Drawing.Point(310, 123);
            this.memoryButton.Name = "memoryButton";
            this.memoryButton.Size = new System.Drawing.Size(58, 34);
            this.memoryButton.TabIndex = 3;
            this.memoryButton.Text = "M";
            this.memoryButton.UseVisualStyleBackColor = false;
            this.memoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // memoryStoreButton
            // 
            this.memoryStoreButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryStoreButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryStoreButton.FlatAppearance.BorderSize = 0;
            this.memoryStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryStoreButton.Location = new System.Drawing.Point(247, 123);
            this.memoryStoreButton.Name = "memoryStoreButton";
            this.memoryStoreButton.Size = new System.Drawing.Size(58, 34);
            this.memoryStoreButton.TabIndex = 4;
            this.memoryStoreButton.Text = "MS";
            this.memoryStoreButton.UseVisualStyleBackColor = false;
            this.memoryStoreButton.Click += new System.EventHandler(this.MemorySaveButton_Click);
            // 
            // memoryMinusButton
            // 
            this.memoryMinusButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryMinusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryMinusButton.FlatAppearance.BorderSize = 0;
            this.memoryMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryMinusButton.Location = new System.Drawing.Point(184, 123);
            this.memoryMinusButton.Name = "memoryMinusButton";
            this.memoryMinusButton.Size = new System.Drawing.Size(58, 34);
            this.memoryMinusButton.TabIndex = 5;
            this.memoryMinusButton.Text = "M-";
            this.memoryMinusButton.UseVisualStyleBackColor = false;
            this.memoryMinusButton.Click += new System.EventHandler(this.MemoryMinusButton_Click);
            // 
            // memoryPlusButton
            // 
            this.memoryPlusButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryPlusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryPlusButton.FlatAppearance.BorderSize = 0;
            this.memoryPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryPlusButton.Location = new System.Drawing.Point(121, 123);
            this.memoryPlusButton.Name = "memoryPlusButton";
            this.memoryPlusButton.Size = new System.Drawing.Size(58, 34);
            this.memoryPlusButton.TabIndex = 6;
            this.memoryPlusButton.Text = "M+";
            this.memoryPlusButton.UseVisualStyleBackColor = false;
            this.memoryPlusButton.Click += new System.EventHandler(this.MemoryPlusButton_Click);
            // 
            // memoryReadButton
            // 
            this.memoryReadButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryReadButton.Enabled = false;
            this.memoryReadButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryReadButton.FlatAppearance.BorderSize = 0;
            this.memoryReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryReadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryReadButton.Location = new System.Drawing.Point(58, 123);
            this.memoryReadButton.Name = "memoryReadButton";
            this.memoryReadButton.Size = new System.Drawing.Size(58, 34);
            this.memoryReadButton.TabIndex = 7;
            this.memoryReadButton.Text = "MR";
            this.memoryReadButton.UseVisualStyleBackColor = false;
            this.memoryReadButton.Click += new System.EventHandler(this.MemoryReadButton_Click);
            // 
            // memoryClearButton
            // 
            this.memoryClearButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.memoryClearButton.Enabled = false;
            this.memoryClearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryClearButton.FlatAppearance.BorderSize = 0;
            this.memoryClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryClearButton.Location = new System.Drawing.Point(-1, 123);
            this.memoryClearButton.Name = "memoryClearButton";
            this.memoryClearButton.Size = new System.Drawing.Size(53, 34);
            this.memoryClearButton.TabIndex = 8;
            this.memoryClearButton.Text = "MC";
            this.memoryClearButton.UseVisualStyleBackColor = false;
            this.memoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.Color.LightGray;
            this.percentButton.FlatAppearance.BorderSize = 0;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Location = new System.Drawing.Point(1, 159);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(91, 53);
            this.percentButton.TabIndex = 9;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.Color.LightGray;
            this.clearEntryButton.FlatAppearance.BorderSize = 0;
            this.clearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntryButton.Location = new System.Drawing.Point(94, 159);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(91, 53);
            this.clearEntryButton.TabIndex = 10;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightGray;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(187, 159);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 53);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.LightGray;
            this.backspaceButton.FlatAppearance.BorderSize = 0;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("backspaceButton.Image")));
            this.backspaceButton.Location = new System.Drawing.Point(280, 159);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(91, 53);
            this.backspaceButton.TabIndex = 12;
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // oneByXButton
            // 
            this.oneByXButton.BackColor = System.Drawing.Color.LightGray;
            this.oneByXButton.FlatAppearance.BorderSize = 0;
            this.oneByXButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneByXButton.Image = ((System.Drawing.Image)(resources.GetObject("oneByXButton.Image")));
            this.oneByXButton.Location = new System.Drawing.Point(1, 214);
            this.oneByXButton.Name = "oneByXButton";
            this.oneByXButton.Size = new System.Drawing.Size(91, 53);
            this.oneByXButton.TabIndex = 13;
            this.oneByXButton.UseVisualStyleBackColor = false;
            this.oneByXButton.Click += new System.EventHandler(this.OneByXButton_Click);
            // 
            // xSquareButton
            // 
            this.xSquareButton.BackColor = System.Drawing.Color.LightGray;
            this.xSquareButton.FlatAppearance.BorderSize = 0;
            this.xSquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xSquareButton.Image = ((System.Drawing.Image)(resources.GetObject("xSquareButton.Image")));
            this.xSquareButton.Location = new System.Drawing.Point(94, 214);
            this.xSquareButton.Name = "xSquareButton";
            this.xSquareButton.Size = new System.Drawing.Size(91, 53);
            this.xSquareButton.TabIndex = 14;
            this.xSquareButton.UseVisualStyleBackColor = false;
            this.xSquareButton.Click += new System.EventHandler(this.XSquareButton_Click);
            // 
            // rootXButton
            // 
            this.rootXButton.BackColor = System.Drawing.Color.LightGray;
            this.rootXButton.FlatAppearance.BorderSize = 0;
            this.rootXButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rootXButton.Image = ((System.Drawing.Image)(resources.GetObject("rootXButton.Image")));
            this.rootXButton.Location = new System.Drawing.Point(187, 214);
            this.rootXButton.Name = "rootXButton";
            this.rootXButton.Size = new System.Drawing.Size(91, 53);
            this.rootXButton.TabIndex = 15;
            this.rootXButton.UseVisualStyleBackColor = false;
            this.rootXButton.Click += new System.EventHandler(this.RootXButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.LightGray;
            this.divisionButton.FlatAppearance.BorderSize = 0;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Image = ((System.Drawing.Image)(resources.GetObject("divisionButton.Image")));
            this.divisionButton.Location = new System.Drawing.Point(280, 214);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(91, 53);
            this.divisionButton.TabIndex = 16;
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.BackColor = System.Drawing.Color.LightGray;
            this.multiplicationButton.FlatAppearance.BorderSize = 0;
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicationButton.Image = ((System.Drawing.Image)(resources.GetObject("multiplicationButton.Image")));
            this.multiplicationButton.Location = new System.Drawing.Point(280, 269);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(91, 53);
            this.multiplicationButton.TabIndex = 17;
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.LightGray;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Image = ((System.Drawing.Image)(resources.GetObject("minusButton.Image")));
            this.minusButton.Location = new System.Drawing.Point(280, 324);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(91, 53);
            this.minusButton.TabIndex = 18;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.LightGray;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Image = ((System.Drawing.Image)(resources.GetObject("plusButton.Image")));
            this.plusButton.Location = new System.Drawing.Point(280, 379);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(91, 53);
            this.plusButton.TabIndex = 19;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Image = ((System.Drawing.Image)(resources.GetObject("equalButton.Image")));
            this.equalButton.Location = new System.Drawing.Point(280, 434);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(91, 53);
            this.equalButton.TabIndex = 20;
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.Control;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Location = new System.Drawing.Point(94, 434);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(91, 53);
            this.zeroButton.TabIndex = 21;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.Control;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Location = new System.Drawing.Point(1, 379);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(91, 53);
            this.oneButton.TabIndex = 22;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.Control;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Location = new System.Drawing.Point(94, 379);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(91, 53);
            this.twoButton.TabIndex = 23;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.Control;
            this.threeButton.FlatAppearance.BorderSize = 0;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Location = new System.Drawing.Point(187, 379);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(91, 53);
            this.threeButton.TabIndex = 24;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.Control;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Location = new System.Drawing.Point(1, 324);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(91, 53);
            this.fourButton.TabIndex = 25;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.Control;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Location = new System.Drawing.Point(94, 324);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(91, 53);
            this.fiveButton.TabIndex = 26;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.Control;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Location = new System.Drawing.Point(187, 324);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(91, 53);
            this.sixButton.TabIndex = 27;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.Control;
            this.sevenButton.FlatAppearance.BorderSize = 0;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Location = new System.Drawing.Point(1, 269);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(91, 53);
            this.sevenButton.TabIndex = 28;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.Control;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Location = new System.Drawing.Point(94, 269);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(91, 53);
            this.eightButton.TabIndex = 29;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.Control;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Location = new System.Drawing.Point(187, 269);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(91, 53);
            this.nineButton.TabIndex = 30;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.SystemColors.Control;
            this.pointButton.FlatAppearance.BorderSize = 0;
            this.pointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.Location = new System.Drawing.Point(187, 434);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(91, 53);
            this.pointButton.TabIndex = 31;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            this.pointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.BackColor = System.Drawing.SystemColors.Control;
            this.plusMinusButton.FlatAppearance.BorderSize = 0;
            this.plusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("plusMinusButton.Image")));
            this.plusMinusButton.Location = new System.Drawing.Point(1, 434);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(91, 53);
            this.plusMinusButton.TabIndex = 32;
            this.plusMinusButton.UseVisualStyleBackColor = false;
            this.plusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(375, 492);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.rootXButton);
            this.Controls.Add(this.xSquareButton);
            this.Controls.Add(this.oneByXButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.memoryClearButton);
            this.Controls.Add(this.memoryReadButton);
            this.Controls.Add(this.memoryPlusButton);
            this.Controls.Add(this.memoryMinusButton);
            this.Controls.Add(this.memoryStoreButton);
            this.Controls.Add(this.memoryButton);
            this.Controls.Add(this.smallDisplay);
            this.Controls.Add(this.bigDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator - Standard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bigDisplay;
        private System.Windows.Forms.Label smallDisplay;
        private System.Windows.Forms.Button memoryButton;
        private System.Windows.Forms.Button memoryStoreButton;
        private System.Windows.Forms.Button memoryMinusButton;
        private System.Windows.Forms.Button memoryPlusButton;
        private System.Windows.Forms.Button memoryReadButton;
        private System.Windows.Forms.Button memoryClearButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button oneByXButton;
        private System.Windows.Forms.Button xSquareButton;
        private System.Windows.Forms.Button rootXButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button plusMinusButton;
    }
}

