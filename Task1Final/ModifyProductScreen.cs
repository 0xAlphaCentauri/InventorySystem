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
    public partial class ModifyProductScreen : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        int number;
        decimal numberD;
        private bool allowSave()
        {
            return
                (!(string.IsNullOrWhiteSpace(modProdInvBox.Text) || !Int32.TryParse(modProdInvBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modProdPriceBox.Text) || !Decimal.TryParse(modProdPriceBox.Text, out numberD))) &&
                (!(string.IsNullOrWhiteSpace(modProdMaxBox.Text) || !Int32.TryParse(modProdMaxBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modProdMinBox.Text) || !Int32.TryParse(modProdMinBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modProdNameBox.Text)));
        }
        public ModifyProductScreen(Product prod)
        {
            InitializeComponent();
            ModifyProductScreenLoad(prod);
        }
        public void ModifyProductScreenLoad(Product selectedProd)
        {
            ModProdIDBoxText = selectedProd.ProductID;
            ModProdNameBoxText = selectedProd.ProductName;
            ModProdInvBoxText = selectedProd.ProductInventory;
            ModProdPriceBoxText = selectedProd.Price;
            ModProdMaxBoxText = selectedProd.Max;
            ModProdMinBoxText = selectedProd.Min;

            //all parts (top)
            var bstop = new BindingSource();
            bstop.DataSource = Inventory.Parts;
            modifyProductGrid1.DataSource = bstop;
            modifyProductGrid1.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid1.Columns["PartName"].HeaderText = "Part Name";
            modifyProductGrid1.Columns["PartInventory"].HeaderText = "Inventory";
            modifyProductGrid1.Columns["Price"].HeaderText = "Price per unit";
            modifyProductGrid1.Columns["Max"].Visible = false;
            modifyProductGrid1.Columns["Min"].Visible = false;

            //lower table
            foreach(Part part in selectedProd.AssociatedParts)
            {
                partsToAdd.Add(part);
            }

            var bsbot = new BindingSource();
            bsbot.DataSource = partsToAdd;
            modifyProductGrid2.DataSource = bsbot;
            modifyProductGrid2.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid2.Columns["PartName"].HeaderText = "Part Name";
            modifyProductGrid2.Columns["PartInventory"].HeaderText = "Inventory";
            modifyProductGrid2.Columns["Price"].HeaderText = "Price per Unit";
            modifyProductGrid2.Columns["Max"].Visible = false;
            modifyProductGrid2.Columns["Min"].Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Part currentPart = (Part)modifyProductGrid2.CurrentRow.DataBoundItem;

            int lookupID = this.ModProdIDBoxText;
            Product currentProd = Inventory.LookupProduct(lookupID);
            currentProd.RemoveAssociatedPart(currentPart.PartID);

            foreach (DataGridViewRow row in modifyProductGrid2.SelectedRows)
            {
                modifyProductGrid2.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Deleted Product");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            modifyProductGrid1.ClearSelection();
            int searchValue = int.Parse(searchBoxModProd.Text);
            if (searchValue < 1)
            {
                return;
            }


            foreach (DataGridViewRow row in modifyProductGrid1.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                Part match = Inventory.LookupPart(searchValue);
                if (match.PartID == part.PartID)
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
        private void Add_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)modifyProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ModProdMaxBoxText< ModProdMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum.");
                return;
            }
            if ((ModProdMaxBoxText < ModProdInvBoxText) || (ModProdInvBoxText < ModProdMinBoxText))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }

            Product updatedProduct = new Product(ModProdIDBoxText, ModProdNameBoxText, ModProdInvBoxText, ModProdPriceBoxText, ModProdMaxBoxText, ModProdMinBoxText);
            int id = ModProdIDBoxText;
            foreach (Part newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }
            Inventory.UpdateProduct(id, updatedProduct);
            this.Hide();
            //MainScreen.home.Show();
            MainForm.mainPartsGrid.Refresh();
            MainForm.mainProductsGrid.Refresh();


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainScreen.home.Show();
        }

        //private void modProdIDBox_TextChanged(object sender, EventArgs e)
        //{ 
        //        if (string.IsNullOrWhiteSpace(modProdIDBox.Text) || !Int32.TryParse(modProdIDBox.Text, out number))
        //        {
        //        modProdIDBox.BackColor = System.Drawing.Color.Salmon;
        //        }
        //        else
        //        {
        //        modProdIDBox.BackColor = System.Drawing.Color.AliceBlue;
        //        }
        //    Save.Enabled = allowSave();
        //}
        private void modProdNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdNameBox.Text))
            {
                modProdNameBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modProdNameBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            Save.Enabled = allowSave();
        }

        private void modProdInvBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdInvBox.Text) || !Int32.TryParse(modProdInvBox.Text, out number))
            {
                modProdInvBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modProdInvBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            Save.Enabled = allowSave();
        }

        private void modProdPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdPriceBox.Text) || !Decimal.TryParse(modProdPriceBox.Text, out numberD))
            {
                modProdPriceBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modProdPriceBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            Save.Enabled = allowSave();
        }

        private void modProdMaxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdMaxBox.Text) || !Int32.TryParse(modProdMaxBox.Text, out number))
            {
                modProdMaxBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modProdMaxBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            Save.Enabled = allowSave();
        }

        private void modProdMinBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdMinBox.Text) || !Int32.TryParse(modProdMinBox.Text, out number))
            {
                modProdMinBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modProdMinBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            Save.Enabled = allowSave();
        }
    }
}
