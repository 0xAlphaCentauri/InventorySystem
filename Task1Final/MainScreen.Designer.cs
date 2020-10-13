namespace Task1Final
{
    partial class MainScreen
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
            this.mainPartsGrid = new System.Windows.Forms.DataGridView();
            this.mainProductsGrid = new System.Windows.Forms.DataGridView();
            this.addPartbtn = new System.Windows.Forms.Button();
            this.modifyPartBtn = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.deletePart = new System.Windows.Forms.Button();
            this.dltPart = new System.Windows.Forms.Button();
            this.searchPart = new System.Windows.Forms.Button();
            this.searchProduct = new System.Windows.Forms.Button();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.closeMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPartsGrid
            // 
            this.mainPartsGrid.AllowUserToAddRows = false;
            this.mainPartsGrid.AllowUserToDeleteRows = false;
            this.mainPartsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainPartsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsGrid.Location = new System.Drawing.Point(73, 194);
            this.mainPartsGrid.Name = "mainPartsGrid";
            this.mainPartsGrid.ReadOnly = true;
            this.mainPartsGrid.RowHeadersVisible = false;
            this.mainPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsGrid.Size = new System.Drawing.Size(444, 196);
            this.mainPartsGrid.TabIndex = 0;
            this.mainPartsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainPartsGrid_CellClick);
            // 
            // mainProductsGrid
            // 
            this.mainProductsGrid.AllowUserToAddRows = false;
            this.mainProductsGrid.AllowUserToDeleteRows = false;
            this.mainProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainProductsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsGrid.Location = new System.Drawing.Point(708, 194);
            this.mainProductsGrid.Name = "mainProductsGrid";
            this.mainProductsGrid.ReadOnly = true;
            this.mainProductsGrid.RowHeadersVisible = false;
            this.mainProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductsGrid.Size = new System.Drawing.Size(444, 196);
            this.mainProductsGrid.TabIndex = 1;
            // 
            // addPartbtn
            // 
            this.addPartbtn.Location = new System.Drawing.Point(280, 396);
            this.addPartbtn.Name = "addPartbtn";
            this.addPartbtn.Size = new System.Drawing.Size(75, 23);
            this.addPartbtn.TabIndex = 2;
            this.addPartbtn.Text = "Add";
            this.addPartbtn.UseVisualStyleBackColor = true;
            this.addPartbtn.Click += new System.EventHandler(this.addPartbtn_Click);
            // 
            // modifyPartBtn
            // 
            this.modifyPartBtn.Location = new System.Drawing.Point(361, 396);
            this.modifyPartBtn.Name = "modifyPartBtn";
            this.modifyPartBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyPartBtn.TabIndex = 3;
            this.modifyPartBtn.Text = "Modify";
            this.modifyPartBtn.UseVisualStyleBackColor = true;
            this.modifyPartBtn.Click += new System.EventHandler(this.modifyPartBtn_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(914, 396);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(995, 396);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 5;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(417, 155);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(100, 20);
            this.searchBoxParts.TabIndex = 6;
            this.searchBoxParts.TextChanged += new System.EventHandler(this.searchBoxParts_TextChanged);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(442, 397);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 7;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click);
            // 
            // dltPart
            // 
            this.dltPart.Location = new System.Drawing.Point(1076, 396);
            this.dltPart.Name = "dltPart";
            this.dltPart.Size = new System.Drawing.Size(75, 23);
            this.dltPart.TabIndex = 8;
            this.dltPart.Text = "Delete";
            this.dltPart.UseVisualStyleBackColor = true;
            this.dltPart.Click += new System.EventHandler(this.dltPart_Click);
            // 
            // searchPart
            // 
            this.searchPart.Location = new System.Drawing.Point(336, 152);
            this.searchPart.Name = "searchPart";
            this.searchPart.Size = new System.Drawing.Size(75, 23);
            this.searchPart.TabIndex = 9;
            this.searchPart.Text = "Search";
            this.searchPart.UseVisualStyleBackColor = true;
            this.searchPart.Click += new System.EventHandler(this.searchPart_Click);
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(970, 165);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(75, 23);
            this.searchProduct.TabIndex = 11;
            this.searchProduct.Text = "Search";
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(1051, 167);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(100, 20);
            this.searchBoxProducts.TabIndex = 12;
            this.searchBoxProducts.TextChanged += new System.EventHandler(this.searchBoxProducts_TextChanged);
            // 
            // closeMain
            // 
            this.closeMain.Location = new System.Drawing.Point(1076, 552);
            this.closeMain.Name = "closeMain";
            this.closeMain.Size = new System.Drawing.Size(75, 23);
            this.closeMain.TabIndex = 13;
            this.closeMain.Text = "Close";
            this.closeMain.UseVisualStyleBackColor = true;
            this.closeMain.Click += new System.EventHandler(this.closeMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inventory Management System";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeMain);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.searchPart);
            this.Controls.Add(this.dltPart);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.searchBoxParts);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.modifyPartBtn);
            this.Controls.Add(this.addPartbtn);
            this.Controls.Add(this.mainProductsGrid);
            this.Controls.Add(this.mainPartsGrid);
            this.Name = "MainScreen";
            this.Text = "MainTest";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView mainPartsGrid;
        public System.Windows.Forms.DataGridView mainProductsGrid;
        private System.Windows.Forms.Button addPartbtn;
        private System.Windows.Forms.Button modifyPartBtn;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button dltPart;
        private System.Windows.Forms.Button searchPart;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button closeMain;
        private System.Windows.Forms.Label label1;

        public int searchBoxPartsText
        {
            get { return int.Parse(searchBoxParts.Text); }
            set { searchBoxParts.Text = value.ToString(); }
        }

        public int searchBoxProductsText
        {
            get { return int.Parse(searchBoxProducts.Text); }
            set { searchBoxProducts.Text = value.ToString(); }
        }
    }
}