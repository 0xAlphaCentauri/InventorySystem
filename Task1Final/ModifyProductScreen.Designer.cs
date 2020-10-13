namespace Task1Final
{
    partial class ModifyProductScreen
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
            this.searchBoxModProd = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.modifyProductGrid1 = new System.Windows.Forms.DataGridView();
            this.modifyProductGrid2 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.modProdIDBox = new System.Windows.Forms.TextBox();
            this.modProdNameBox = new System.Windows.Forms.TextBox();
            this.modProdInvBox = new System.Windows.Forms.TextBox();
            this.modProdPriceBox = new System.Windows.Forms.TextBox();
            this.modProdMaxBox = new System.Windows.Forms.TextBox();
            this.modProdMinBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // searchBoxModProd
            // 
            this.searchBoxModProd.Location = new System.Drawing.Point(979, 45);
            this.searchBoxModProd.Name = "searchBoxModProd";
            this.searchBoxModProd.Size = new System.Drawing.Size(100, 20);
            this.searchBoxModProd.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(898, 42);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // modifyProductGrid1
            // 
            this.modifyProductGrid1.AllowUserToAddRows = false;
            this.modifyProductGrid1.AllowUserToDeleteRows = false;
            this.modifyProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductGrid1.Location = new System.Drawing.Point(600, 83);
            this.modifyProductGrid1.Name = "modifyProductGrid1";
            this.modifyProductGrid1.ReadOnly = true;
            this.modifyProductGrid1.RowHeadersVisible = false;
            this.modifyProductGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyProductGrid1.Size = new System.Drawing.Size(505, 150);
            this.modifyProductGrid1.TabIndex = 3;
            // 
            // modifyProductGrid2
            // 
            this.modifyProductGrid2.AllowUserToAddRows = false;
            this.modifyProductGrid2.AllowUserToDeleteRows = false;
            this.modifyProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductGrid2.Location = new System.Drawing.Point(600, 321);
            this.modifyProductGrid2.Name = "modifyProductGrid2";
            this.modifyProductGrid2.ReadOnly = true;
            this.modifyProductGrid2.RowHeadersVisible = false;
            this.modifyProductGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyProductGrid2.Size = new System.Drawing.Size(505, 150);
            this.modifyProductGrid2.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1026, 239);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(53, 40);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1026, 477);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(53, 40);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(1026, 537);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(53, 40);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(951, 537);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(53, 40);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // modProdIDBox
            // 
            this.modProdIDBox.Location = new System.Drawing.Point(129, 161);
            this.modProdIDBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdIDBox.Name = "modProdIDBox";
            this.modProdIDBox.ReadOnly = true;
            this.modProdIDBox.Size = new System.Drawing.Size(100, 20);
            this.modProdIDBox.TabIndex = 9;
            // 
            // modProdNameBox
            // 
            this.modProdNameBox.Location = new System.Drawing.Point(129, 191);
            this.modProdNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdNameBox.Name = "modProdNameBox";
            this.modProdNameBox.Size = new System.Drawing.Size(100, 20);
            this.modProdNameBox.TabIndex = 10;
            this.modProdNameBox.TextChanged += new System.EventHandler(this.modProdNameBox_TextChanged);
            // 
            // modProdInvBox
            // 
            this.modProdInvBox.Location = new System.Drawing.Point(129, 221);
            this.modProdInvBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdInvBox.Name = "modProdInvBox";
            this.modProdInvBox.Size = new System.Drawing.Size(100, 20);
            this.modProdInvBox.TabIndex = 11;
            this.modProdInvBox.TextChanged += new System.EventHandler(this.modProdInvBox_TextChanged);
            // 
            // modProdPriceBox
            // 
            this.modProdPriceBox.Location = new System.Drawing.Point(129, 259);
            this.modProdPriceBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdPriceBox.Name = "modProdPriceBox";
            this.modProdPriceBox.Size = new System.Drawing.Size(100, 20);
            this.modProdPriceBox.TabIndex = 12;
            this.modProdPriceBox.TextChanged += new System.EventHandler(this.modProdPriceBox_TextChanged);
            // 
            // modProdMaxBox
            // 
            this.modProdMaxBox.Location = new System.Drawing.Point(81, 289);
            this.modProdMaxBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdMaxBox.Name = "modProdMaxBox";
            this.modProdMaxBox.Size = new System.Drawing.Size(77, 20);
            this.modProdMaxBox.TabIndex = 13;
            this.modProdMaxBox.TextChanged += new System.EventHandler(this.modProdMaxBox_TextChanged);
            // 
            // modProdMinBox
            // 
            this.modProdMinBox.Location = new System.Drawing.Point(215, 289);
            this.modProdMinBox.Margin = new System.Windows.Forms.Padding(5);
            this.modProdMinBox.Name = "modProdMinBox";
            this.modProdMinBox.Size = new System.Drawing.Size(64, 20);
            this.modProdMinBox.TabIndex = 14;
            this.modProdMinBox.TextChanged += new System.EventHandler(this.modProdMinBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 164);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID (Auto)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 194);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 224);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 262);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 292);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 292);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Min";
            // 
            // ModifyProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 608);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modProdMinBox);
            this.Controls.Add(this.modProdMaxBox);
            this.Controls.Add(this.modProdPriceBox);
            this.Controls.Add(this.modProdInvBox);
            this.Controls.Add(this.modProdNameBox);
            this.Controls.Add(this.modProdIDBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.modifyProductGrid2);
            this.Controls.Add(this.modifyProductGrid1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchBoxModProd);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProductScreen";
            this.Text = "ModifyProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBoxModProd;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView modifyProductGrid1;
        private System.Windows.Forms.DataGridView modifyProductGrid2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox modProdIDBox;
        private System.Windows.Forms.TextBox modProdNameBox;
        private System.Windows.Forms.TextBox modProdInvBox;
        private System.Windows.Forms.TextBox modProdPriceBox;
        private System.Windows.Forms.TextBox modProdMaxBox;
        private System.Windows.Forms.TextBox modProdMinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        public int ModProdIDBoxText
        {
            get { return int.Parse(modProdIDBox.Text); }
            set { modProdIDBox.Text = value.ToString(); }
        }
        public string ModProdNameBoxText
        {
            get { return modProdNameBox.Text; }
            set { modProdNameBox.Text = value; }
        }
        public int ModProdInvBoxText
        {
            get { return int.Parse(modProdInvBox.Text); }
            set { modProdInvBox.Text = value.ToString(); }
        }
        public decimal ModProdPriceBoxText
        {
            get { return decimal.Parse(modProdPriceBox.Text); }
            set { modProdPriceBox.Text = value.ToString(); }
        }
        public int ModProdMaxBoxText
        {
            get { return int.Parse(modProdMaxBox.Text); }
            set { modProdMaxBox.Text = value.ToString(); }
        }
        public int ModProdMinBoxText
        {
            get { return int.Parse(modProdMinBox.Text); }
            set { modProdMinBox.Text = value.ToString(); }
        }
    }
}