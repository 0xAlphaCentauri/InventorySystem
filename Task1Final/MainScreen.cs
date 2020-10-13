using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Final
{
    public partial class MainScreen : Form
    {
        //public static MainScreen home = new MainScreen();
        public MainScreen()
        {
            InitializeComponent();
            //InitializeDummy();
            MainScreenFormLoad();
        }

        private void MainScreen_Load(object sender, EventArgs e) //test
        {
            mainPartsGrid.DataSource = Inventory.Parts;
            mainPartsGrid.ClearSelection();
            mainPartsGrid.Refresh();

            mainProductsGrid.DataSource = Inventory.Products;
            mainProductsGrid.ClearSelection();
            mainProductsGrid.Refresh();
        }

        //public void InitializeDummy()
        //{
        //    var bsPart = new BindingSource();
        //    bsPart.DataSource = Inventory.Parts;
        //    mainPartsGrid.DataSource = bsPart;

        //    var bsProd = new BindingSource();
        //    bsProd.DataSource = Inventory.Products;
        //    mainProductsGrid.DataSource = bsProd;

        //}



        public void MainScreenFormLoad()
        {
            //populate dummies
            Inventory.PopulateDummyLists();

            //Left table, parts, filled
            var bsPart = new BindingSource();
            bsPart.DataSource = Inventory.Parts;
            mainPartsGrid.DataSource = bsPart;

            mainPartsGrid.Columns["PartID"].HeaderText = "Part ID";
            mainPartsGrid.Columns["PartName"].HeaderText = "Part Name";
            mainPartsGrid.Columns["PartInventory"].HeaderText = "Inventory";
            mainPartsGrid.Columns["Price"].HeaderText = "Price";
            mainPartsGrid.Columns["Max"].Visible = false;
            mainPartsGrid.Columns["Min"].Visible = false;

            //products into right table
            var bsProd = new BindingSource();
            bsProd.DataSource = Inventory.Products;
            mainProductsGrid.DataSource = bsProd;

            mainProductsGrid.Columns["ProductID"].HeaderText = "Product ID";
            mainProductsGrid.Columns["ProductName"].HeaderText = "Product Name";
            mainProductsGrid.Columns["ProductInventory"].HeaderText = "Inventory";
            mainProductsGrid.Columns["Price"].HeaderText = "Price per unit";
            mainProductsGrid.Columns["Max"].Visible = false;
            mainProductsGrid.Columns["Min"].Visible = false;
        }


        private void addPartbtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AddPartScreen addPart = new AddPartScreen();
            //addPart.Show();
            new AddPartScreen().ShowDialog();
        }

        private void modifyPartBtn_Click(object sender, EventArgs e)
        {
                //InHousePart inPart = (InHousePart)mainPartsGrid.CurrentRow.DataBoundItem;
                //this.Hide();
                new ModifyPartScreen().ShowDialog();
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            new AddProductScreen().ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            new ModifyProductScreen(selectedProduct).ShowDialog();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in mainPartsGrid.SelectedRows)
            {
                mainPartsGrid.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Deleted Part");
        }

        private void dltPart_Click(object sender, EventArgs e)
        {
            Product prod = (Product)mainProductsGrid.CurrentRow.DataBoundItem;
            if (prod.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a product with at least 1 part assigned to it. \nPlease remove assigned parts.");
                return;
            }
            foreach (DataGridViewRow row in mainProductsGrid.SelectedRows)
            {
                mainProductsGrid.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Deleted Product");
        }

        private void searchPart_Click(object sender, EventArgs e)
        {
            if (searchBoxPartsText < 1)
                return;
            mainPartsGrid.ClearSelection();

            Part match = Inventory.LookupPart(searchBoxPartsText);

            foreach(DataGridViewRow row in mainPartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            if (searchBoxProductsText < 1)
                return;

            mainProductsGrid.ClearSelection();
            Product match = Inventory.LookupProduct(searchBoxProductsText);

            foreach(DataGridViewRow row in mainProductsGrid.Rows)
            {
                Product prod = (Product)row.DataBoundItem;

                if (prod.ProductID == match.ProductID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void closeMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBoxParts_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(searchBoxParts.Text) || !Int32.TryParse(searchBoxParts.Text, out number))
            {
                searchBoxParts.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                searchBoxParts.BackColor = System.Drawing.Color.AliceBlue;
            }
        }

        private void searchBoxProducts_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(searchBoxProducts.Text) || !Int32.TryParse(searchBoxProducts.Text, out number))
            {
                searchBoxProducts.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                searchBoxProducts.BackColor = System.Drawing.Color.AliceBlue;
            }
        }

        private void mainPartsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.grid1Index = e.RowIndex;
        }
    }
}
