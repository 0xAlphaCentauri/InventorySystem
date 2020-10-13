namespace Task1Final
{
    partial class AddProductScreen
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
            this.addProductGrid1 = new System.Windows.Forms.DataGridView();
            this.addProductGrid2 = new System.Windows.Forms.DataGridView();
            this.addProdIDBox = new System.Windows.Forms.TextBox();
            this.addProdNameBox = new System.Windows.Forms.TextBox();
            this.addProdInvBox = new System.Windows.Forms.TextBox();
            this.addProdPriceBox = new System.Windows.Forms.TextBox();
            this.addProdMaxBox = new System.Windows.Forms.TextBox();
            this.addProdMinBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddProd = new System.Windows.Forms.Button();
            this.searchBoxAddProd = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductGrid1
            // 
            this.addProductGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid1.Location = new System.Drawing.Point(368, 79);
            this.addProductGrid1.Name = "addProductGrid1";
            this.addProductGrid1.RowHeadersVisible = false;
            this.addProductGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGrid1.Size = new System.Drawing.Size(462, 144);
            this.addProductGrid1.TabIndex = 1;
            // 
            // addProductGrid2
            // 
            this.addProductGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid2.Location = new System.Drawing.Point(368, 320);
            this.addProductGrid2.Name = "addProductGrid2";
            this.addProductGrid2.RowHeadersVisible = false;
            this.addProductGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGrid2.Size = new System.Drawing.Size(462, 144);
            this.addProductGrid2.TabIndex = 2;
            // 
            // addProdIDBox
            // 
            this.addProdIDBox.Location = new System.Drawing.Point(110, 182);
            this.addProdIDBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.addProdIDBox.Name = "addProdIDBox";
            this.addProdIDBox.ReadOnly = true;
            this.addProdIDBox.Size = new System.Drawing.Size(124, 20);
            this.addProdIDBox.TabIndex = 3;
            // 
            // addProdNameBox
            // 
            this.addProdNameBox.Location = new System.Drawing.Point(110, 215);
            this.addProdNameBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.addProdNameBox.Name = "addProdNameBox";
            this.addProdNameBox.Size = new System.Drawing.Size(124, 20);
            this.addProdNameBox.TabIndex = 4;
            this.addProdNameBox.TextChanged += new System.EventHandler(this.addProdNameBox_TextChanged);
            // 
            // addProdInvBox
            // 
            this.addProdInvBox.Location = new System.Drawing.Point(110, 248);
            this.addProdInvBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.addProdInvBox.Name = "addProdInvBox";
            this.addProdInvBox.Size = new System.Drawing.Size(124, 20);
            this.addProdInvBox.TabIndex = 5;
            this.addProdInvBox.TextChanged += new System.EventHandler(this.addProdInvBox_TextChanged);
            // 
            // addProdPriceBox
            // 
            this.addProdPriceBox.Location = new System.Drawing.Point(110, 281);
            this.addProdPriceBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.addProdPriceBox.Name = "addProdPriceBox";
            this.addProdPriceBox.Size = new System.Drawing.Size(124, 20);
            this.addProdPriceBox.TabIndex = 6;
            this.addProdPriceBox.TextChanged += new System.EventHandler(this.addProdPriceBox_TextChanged);
            // 
            // addProdMaxBox
            // 
            this.addProdMaxBox.Location = new System.Drawing.Point(87, 320);
            this.addProdMaxBox.Name = "addProdMaxBox";
            this.addProdMaxBox.Size = new System.Drawing.Size(69, 20);
            this.addProdMaxBox.TabIndex = 7;
            this.addProdMaxBox.TextChanged += new System.EventHandler(this.addProdMaxBox_TextChanged);
            // 
            // addProdMinBox
            // 
            this.addProdMinBox.Location = new System.Drawing.Point(224, 320);
            this.addProdMinBox.Name = "addProdMinBox";
            this.addProdMinBox.Size = new System.Drawing.Size(69, 20);
            this.addProdMinBox.TabIndex = 8;
            this.addProdMinBox.TextChanged += new System.EventHandler(this.addProdMinBox_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(41, 181);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(66, 18);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID (Auto)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Min";
            // 
            // AddProd
            // 
            this.AddProd.Location = new System.Drawing.Point(743, 229);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(67, 36);
            this.AddProd.TabIndex = 15;
            this.AddProd.Text = "Add";
            this.AddProd.UseVisualStyleBackColor = true;
            this.AddProd.Click += new System.EventHandler(this.Add_Click);
            // 
            // searchBoxAddProd
            // 
            this.searchBoxAddProd.Location = new System.Drawing.Point(710, 41);
            this.searchBoxAddProd.Name = "searchBoxAddProd";
            this.searchBoxAddProd.Size = new System.Drawing.Size(100, 20);
            this.searchBoxAddProd.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(629, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(743, 470);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(67, 36);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(659, 549);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(67, 36);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(743, 549);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(67, 36);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Add Product";
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 613);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBoxAddProd);
            this.Controls.Add(this.AddProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.addProdMinBox);
            this.Controls.Add(this.addProdMaxBox);
            this.Controls.Add(this.addProdPriceBox);
            this.Controls.Add(this.addProdInvBox);
            this.Controls.Add(this.addProdNameBox);
            this.Controls.Add(this.addProdIDBox);
            this.Controls.Add(this.addProductGrid2);
            this.Controls.Add(this.addProductGrid1);
            this.Name = "AddProductScreen";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addProductGrid1;
        private System.Windows.Forms.DataGridView addProductGrid2;
        private System.Windows.Forms.TextBox addProdIDBox;
        private System.Windows.Forms.TextBox addProdNameBox;
        private System.Windows.Forms.TextBox addProdInvBox;
        private System.Windows.Forms.TextBox addProdPriceBox;
        private System.Windows.Forms.TextBox addProdMaxBox;
        private System.Windows.Forms.TextBox addProdMinBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.TextBox searchBoxAddProd;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label6;

        public int AddProdIDBoxText
        {
            get { return int.Parse(addProdIDBox.Text); }
            set { addProdIDBox.Text = value.ToString(); }
        }
        public string AddProdNameBoxText
        {
            get { return addProdNameBox.Text; }
            set { addProdNameBox.Text = value; }
        }
        public int AddProdInvBoxText
        {
            get { return int.Parse(addProdInvBox.Text); }
            set { addProdInvBox.Text = value.ToString(); }
        }
        public decimal AddProdPriceBoxText
        {
            get { return decimal.Parse(addProdPriceBox.Text); }
            set { addProdPriceBox.Text = value.ToString(); }
        }
        public int AddProdMaxBoxText
        {
            get { return int.Parse(addProdMaxBox.Text); }
            set { addProdMaxBox.Text = value.ToString(); }
        }
        public int AddProdMinBoxText
        {
            get { return int.Parse(addProdMinBox.Text); }
            set { addProdMinBox.Text = value.ToString(); }
        }
    }
}