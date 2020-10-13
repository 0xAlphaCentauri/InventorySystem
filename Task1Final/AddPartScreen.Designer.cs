namespace Task1Final
{
    partial class AddPartScreen
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
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.addPartInvBox = new System.Windows.Forms.TextBox();
            this.addPartPriceBox = new System.Windows.Forms.TextBox();
            this.addPartMaxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPartMinBox = new System.Windows.Forms.TextBox();
            this.addPartMachComBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addPartIDBoxText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addPartNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHouse
            // 
            this.InHouse.AutoSize = true;
            this.InHouse.Location = new System.Drawing.Point(112, 12);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(68, 17);
            this.InHouse.TabIndex = 1;
            this.InHouse.TabStop = true;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(203, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outsourced";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // addPartInvBox
            // 
            this.addPartInvBox.Location = new System.Drawing.Point(147, 112);
            this.addPartInvBox.Name = "addPartInvBox";
            this.addPartInvBox.Size = new System.Drawing.Size(100, 20);
            this.addPartInvBox.TabIndex = 5;
            this.addPartInvBox.TextChanged += new System.EventHandler(this.addPartInvBox_TextChanged);
            // 
            // addPartPriceBox
            // 
            this.addPartPriceBox.Location = new System.Drawing.Point(147, 139);
            this.addPartPriceBox.Name = "addPartPriceBox";
            this.addPartPriceBox.Size = new System.Drawing.Size(100, 20);
            this.addPartPriceBox.TabIndex = 6;
            this.addPartPriceBox.TextChanged += new System.EventHandler(this.addPartPriceBox_TextChanged);
            // 
            // addPartMaxBox
            // 
            this.addPartMaxBox.Location = new System.Drawing.Point(147, 166);
            this.addPartMaxBox.Name = "addPartMaxBox";
            this.addPartMaxBox.Size = new System.Drawing.Size(58, 20);
            this.addPartMaxBox.TabIndex = 7;
            this.addPartMaxBox.TextChanged += new System.EventHandler(this.addPartMaxBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartMinBox
            // 
            this.addPartMinBox.Location = new System.Drawing.Point(264, 166);
            this.addPartMinBox.Name = "addPartMinBox";
            this.addPartMinBox.Size = new System.Drawing.Size(56, 20);
            this.addPartMinBox.TabIndex = 9;
            this.addPartMinBox.TextChanged += new System.EventHandler(this.addPartMinBox_TextChanged);
            // 
            // addPartMachComBox
            // 
            this.addPartMachComBox.Location = new System.Drawing.Point(147, 193);
            this.addPartMachComBox.Name = "addPartMachComBox";
            this.addPartMachComBox.Size = new System.Drawing.Size(100, 20);
            this.addPartMachComBox.TabIndex = 10;
            this.addPartMachComBox.TextChanged += new System.EventHandler(this.addPartMachComBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 61);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID (Auto)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inventory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price/Cost";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Machine ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartIDBoxText
            // 
            this.addPartIDBoxText.CausesValidation = global::Task1Final.Properties.Settings.Default.PartID;
            this.addPartIDBoxText.Location = new System.Drawing.Point(147, 58);
            this.addPartIDBoxText.Name = "addPartIDBoxText";
            this.addPartIDBoxText.ReadOnly = true;
            this.addPartIDBoxText.Size = new System.Drawing.Size(100, 20);
            this.addPartIDBoxText.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(234, 239);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(49, 23);
            this.sendButton.TabIndex = 17;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(289, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(49, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addPartNameBox
            // 
            this.addPartNameBox.Location = new System.Drawing.Point(147, 85);
            this.addPartNameBox.Name = "addPartNameBox";
            this.addPartNameBox.Size = new System.Drawing.Size(100, 20);
            this.addPartNameBox.TabIndex = 19;
            this.addPartNameBox.TextChanged += new System.EventHandler(this.addPartNameBox_TextChanged);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 301);
            this.Controls.Add(this.addPartNameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addPartMachComBox);
            this.Controls.Add(this.addPartMinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPartMaxBox);
            this.Controls.Add(this.addPartPriceBox);
            this.Controls.Add(this.addPartInvBox);
            this.Controls.Add(this.addPartIDBoxText);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.InHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox addPartIDBoxText;
        private System.Windows.Forms.TextBox addPartNameBoxText;
        private System.Windows.Forms.TextBox addPartInvBox;
        private System.Windows.Forms.TextBox addPartPriceBox;
        private System.Windows.Forms.TextBox addPartMaxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addPartMinBox;
        private System.Windows.Forms.TextBox addPartMachComBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox addPartNameBox;

        public int AddPartIDBoxText
        {
            get { return int.Parse(addPartIDBoxText.Text); }
            set { addPartIDBoxText.Text = value.ToString(); }
        }
        public string AddPartNameBoxText
        {
            get { return addPartNameBox.Text; }
            set { addPartNameBox.Text = value; }
        }
        public int AddPartInvBoxText
        {
            get { return int.Parse(addPartInvBox.Text); }
            set { addPartInvBox.Text = value.ToString(); }
        }
        public decimal AddPartPriceBoxText
        {
            get { return decimal.Parse(addPartPriceBox.Text); }
            set { addPartPriceBox.Text = value.ToString(); }
        }
        public int AddPartMaxBoxText
        {
            get { return int.Parse(addPartMaxBox.Text); }
            set { addPartMaxBox.Text = value.ToString(); }
        }
        public int AddPartMinBoxText
        {
            get { return int.Parse(addPartMinBox.Text); }
            set { addPartMinBox.Text = value.ToString(); }
        }
        // Keep this as a string since no calculations will be done
        public string AddPartMachComBoxText
        {
            get { return addPartMachComBox.Text; }
            set { addPartMachComBox.Text = value; }
        }
    }
}