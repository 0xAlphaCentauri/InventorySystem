namespace Task1Final
{
    partial class ModifyPartScreen
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
            this.modPartIDBox = new System.Windows.Forms.TextBox();
            this.modPartNameBox = new System.Windows.Forms.TextBox();
            this.modPartInvBox = new System.Windows.Forms.TextBox();
            this.modPartPriceBox = new System.Windows.Forms.TextBox();
            this.modPartMaxBox = new System.Windows.Forms.TextBox();
            this.modPartMinBox = new System.Windows.Forms.TextBox();
            this.modPartMachComBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModPartSave = new System.Windows.Forms.Button();
            this.btnModPartCancel = new System.Windows.Forms.Button();
            this.radioModInhouse = new System.Windows.Forms.RadioButton();
            this.radioModOutsourced = new System.Windows.Forms.RadioButton();
            this.ModifyPart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modPartIDBox
            // 
            this.modPartIDBox.Location = new System.Drawing.Point(128, 52);
            this.modPartIDBox.Name = "modPartIDBox";
            this.modPartIDBox.ReadOnly = true;
            this.modPartIDBox.Size = new System.Drawing.Size(100, 20);
            this.modPartIDBox.TabIndex = 0;
            // 
            // modPartNameBox
            // 
            this.modPartNameBox.Location = new System.Drawing.Point(128, 78);
            this.modPartNameBox.Name = "modPartNameBox";
            this.modPartNameBox.Size = new System.Drawing.Size(100, 20);
            this.modPartNameBox.TabIndex = 1;
            this.modPartNameBox.TextChanged += new System.EventHandler(this.modPartNameBox_TextChanged);
            // 
            // modPartInvBox
            // 
            this.modPartInvBox.Location = new System.Drawing.Point(128, 104);
            this.modPartInvBox.Name = "modPartInvBox";
            this.modPartInvBox.Size = new System.Drawing.Size(100, 20);
            this.modPartInvBox.TabIndex = 2;
            this.modPartInvBox.TextChanged += new System.EventHandler(this.modPartInvBox_TextChanged);
            // 
            // modPartPriceBox
            // 
            this.modPartPriceBox.Location = new System.Drawing.Point(128, 130);
            this.modPartPriceBox.Name = "modPartPriceBox";
            this.modPartPriceBox.Size = new System.Drawing.Size(100, 20);
            this.modPartPriceBox.TabIndex = 3;
            this.modPartPriceBox.TextChanged += new System.EventHandler(this.modPartPriceBox_TextChanged);
            // 
            // modPartMaxBox
            // 
            this.modPartMaxBox.Location = new System.Drawing.Point(128, 156);
            this.modPartMaxBox.Name = "modPartMaxBox";
            this.modPartMaxBox.Size = new System.Drawing.Size(53, 20);
            this.modPartMaxBox.TabIndex = 4;
            this.modPartMaxBox.TextChanged += new System.EventHandler(this.modPartMaxBox_TextChanged);
            // 
            // modPartMinBox
            // 
            this.modPartMinBox.Location = new System.Drawing.Point(273, 156);
            this.modPartMinBox.Name = "modPartMinBox";
            this.modPartMinBox.Size = new System.Drawing.Size(53, 20);
            this.modPartMinBox.TabIndex = 5;
            this.modPartMinBox.TextChanged += new System.EventHandler(this.modPartMinBox_TextChanged);
            // 
            // modPartMachComBox
            // 
            this.modPartMachComBox.Location = new System.Drawing.Point(128, 182);
            this.modPartMachComBox.Name = "modPartMachComBox";
            this.modPartMachComBox.Size = new System.Drawing.Size(100, 20);
            this.modPartMachComBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID (Auto)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price / Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 159);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 159);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 185);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Machine ID";
            // 
            // btnModPartSave
            // 
            this.btnModPartSave.Location = new System.Drawing.Point(212, 223);
            this.btnModPartSave.Name = "btnModPartSave";
            this.btnModPartSave.Size = new System.Drawing.Size(52, 33);
            this.btnModPartSave.TabIndex = 14;
            this.btnModPartSave.Text = "Save";
            this.btnModPartSave.UseVisualStyleBackColor = true;
            this.btnModPartSave.Click += new System.EventHandler(this.btnModPartSave_Click);
            // 
            // btnModPartCancel
            // 
            this.btnModPartCancel.Location = new System.Drawing.Point(277, 223);
            this.btnModPartCancel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnModPartCancel.Name = "btnModPartCancel";
            this.btnModPartCancel.Size = new System.Drawing.Size(52, 33);
            this.btnModPartCancel.TabIndex = 15;
            this.btnModPartCancel.Text = "Cancel";
            this.btnModPartCancel.UseVisualStyleBackColor = true;
            this.btnModPartCancel.Click += new System.EventHandler(this.btnModPartCancel_Click);
            // 
            // radioModInhouse
            // 
            this.radioModInhouse.AutoSize = true;
            this.radioModInhouse.Location = new System.Drawing.Point(137, 7);
            this.radioModInhouse.Name = "radioModInhouse";
            this.radioModInhouse.Size = new System.Drawing.Size(68, 17);
            this.radioModInhouse.TabIndex = 16;
            this.radioModInhouse.Text = "In House";
            this.radioModInhouse.UseMnemonic = false;
            this.radioModInhouse.UseVisualStyleBackColor = true;
            this.radioModInhouse.CheckedChanged += new System.EventHandler(this.radioModInhouse_CheckedChanged);
            // 
            // radioModOutsourced
            // 
            this.radioModOutsourced.AutoSize = true;
            this.radioModOutsourced.Location = new System.Drawing.Point(229, 7);
            this.radioModOutsourced.Name = "radioModOutsourced";
            this.radioModOutsourced.Size = new System.Drawing.Size(85, 17);
            this.radioModOutsourced.TabIndex = 17;
            this.radioModOutsourced.TabStop = true;
            this.radioModOutsourced.Text = "Out Sourced";
            this.radioModOutsourced.UseVisualStyleBackColor = true;
            this.radioModOutsourced.CheckedChanged += new System.EventHandler(this.radioModOutsourced_CheckedChanged);
            // 
            // ModifyPart
            // 
            this.ModifyPart.AutoSize = true;
            this.ModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPart.Location = new System.Drawing.Point(19, 7);
            this.ModifyPart.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(75, 16);
            this.ModifyPart.TabIndex = 18;
            this.ModifyPart.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 274);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.radioModOutsourced);
            this.Controls.Add(this.radioModInhouse);
            this.Controls.Add(this.btnModPartCancel);
            this.Controls.Add(this.btnModPartSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modPartMachComBox);
            this.Controls.Add(this.modPartMinBox);
            this.Controls.Add(this.modPartMaxBox);
            this.Controls.Add(this.modPartPriceBox);
            this.Controls.Add(this.modPartInvBox);
            this.Controls.Add(this.modPartNameBox);
            this.Controls.Add(this.modPartIDBox);
            this.Name = "ModifyPartScreen";
            this.Text = "ModifyPartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modPartIDBox;
        private System.Windows.Forms.TextBox modPartNameBox;
        private System.Windows.Forms.TextBox modPartInvBox;
        private System.Windows.Forms.TextBox modPartPriceBox;
        private System.Windows.Forms.TextBox modPartMaxBox;
        private System.Windows.Forms.TextBox modPartMinBox;
        private System.Windows.Forms.TextBox modPartMachComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModPartSave;
        private System.Windows.Forms.Button btnModPartCancel;
        private System.Windows.Forms.RadioButton radioModInhouse;
        private System.Windows.Forms.RadioButton radioModOutsourced;
        private System.Windows.Forms.Label ModifyPart;

        //text boxes
        public int ModPartIDBoxText
        {
            get { return int.Parse(modPartIDBox.Text); }
            set { modPartIDBox.Text = value.ToString(); }
        }
        public string ModPartNameBoxText
        {
            get { return modPartNameBox.Text; }
            set { modPartNameBox.Text = value; }
        }
        public int ModPartInvBoxText
        {
            get { return int.Parse(modPartInvBox.Text); }
            set { modPartInvBox.Text = value.ToString(); }
        }
        public decimal ModPartPriceBoxText
        {
            get { return decimal.Parse(modPartPriceBox.Text); }
            set { modPartPriceBox.Text = value.ToString(); }
        }

        public int ModPartMaxBoxText
        {
            get { return int.Parse(modPartMaxBox.Text); }
            set { modPartMaxBox.Text = value.ToString(); }
        }
        public int ModPartMinBoxText
        {
            get { return int.Parse(modPartMinBox.Text); }
            set { modPartMinBox.Text = value.ToString(); }
        }
        public string ModPartMachComBoxText
        {
            get { return modPartMachComBox.Text; }
            set { modPartMachComBox.Text = value; }
        }
    }
}