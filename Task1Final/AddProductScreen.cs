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
    public partial class AddProductScreen : Form
    {
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];
        BindingList<Part> partsToAdd = new BindingList<Part>();
        public AddProductScreen()
        {
            InitializeComponent();
            AddProductScreenLoad();
        }

        private bool allowSave()
        {
            int number;
            return 
                (!(string.IsNullOrWhiteSpace(addProdNameBox.Text))) &&
                (!(string.IsNullOrWhiteSpace(addProdInvBox.Text) || !Int32.TryParse(addProdInvBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(addProdPriceBox.Text) || !Int32.TryParse(addProdPriceBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(addProdMinBox.Text) || !Int32.TryParse(addProdMinBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(addProdMaxBox.Text) || !Int32.TryParse(addProdMaxBox.Text, out number)))
                ;
        }

        public void AddProductScreenLoad()
        {
            // The top table contains a list of all parts
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.Parts;
            addProductGrid1.DataSource = bs1;
            addProductGrid1.Columns["PartID"].HeaderText = "Part ID";
            addProductGrid1.Columns["PartName"].HeaderText = "Part Name";
            addProductGrid1.Columns["PartInventory"].HeaderText = "Inventory";
            addProductGrid1.Columns["Price"].HeaderText = "Price per Unit";
            addProductGrid1.Columns["Max"].Visible = false;
            addProductGrid1.Columns["Min"].Visible = false;

            // The lower table contains all parts belonging to the selected Product from the main screen
            var bs2 = new BindingSource();
            bs2.DataSource = partsToAdd;
            addProductGrid2.DataSource = bs2;
            addProductGrid2.Columns["PartID"].HeaderText = "Part ID";
            addProductGrid2.Columns["PartName"].HeaderText = "Part Name";
            addProductGrid2.Columns["PartInventory"].HeaderText = "Inventory";
            addProductGrid2.Columns["Price"].HeaderText = "Price per Unit";
            addProductGrid2.Columns["Max"].Visible = false;
            addProductGrid2.Columns["Min"].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)addProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(searchBoxAddProd.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in addProductGrid1.Rows)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (AddProdMaxBoxText < AddProdMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum.");
                return;
            }
            if ((AddProdMaxBoxText < AddProdInvBoxText) ^ (AddProdInvBoxText < AddProdMinBoxText))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }

            Product productToAdd = new Product((Inventory.Products.Count + 1), AddProdNameBoxText, AddProdInvBoxText, AddProdPriceBoxText, AddProdMaxBoxText, AddProdMinBoxText);
            Inventory.AddProduct(productToAdd);

            foreach(Part part in partsToAdd)
            {
                productToAdd.AddAssociatedPart(part);
            }
            this.Hide();
            MainForm.mainPartsGrid.Refresh();
            MainForm.mainProductsGrid.Refresh();
            //MainScreen.home.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainScreen.home.Show();
        }

        //private void addProdIDBox_TextChanged(object sender, EventArgs e)
        //{
        //    int number;
        //    if (string.IsNullOrWhiteSpace(addProdIDBox.Text) || !Int32.TryParse(addProdIDBox.Text, out number))
        //    {
        //        addProdIDBox.BackColor = System.Drawing.Color.Salmon;
        //    }
        //    else
        //    {
        //        addProdIDBox.BackColor = System.Drawing.Color.AliceBlue;
        //    }
        //    saveBtn.Enabled = allowSave();
        //}

        private void addProdNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addProdNameBox.Text))
            {
                addProdNameBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProdNameBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            saveBtn.Enabled = allowSave();
        }

        private void addProdInvBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addProdInvBox.Text) || !Int32.TryParse(addProdInvBox.Text, out number))
            {
                addProdInvBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProdInvBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            saveBtn.Enabled = allowSave();
        }

        private void addProdPriceBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addProdPriceBox.Text) || !Int32.TryParse(addProdPriceBox.Text, out number))
            {
                addProdPriceBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProdPriceBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            saveBtn.Enabled = allowSave();
        }

        private void addProdMaxBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addProdMaxBox.Text) || !Int32.TryParse(addProdMaxBox.Text, out number))
            {
                addProdMaxBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProdMaxBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            saveBtn.Enabled = allowSave();
        }

        private void addProdMinBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addProdMinBox.Text) || !Int32.TryParse(addProdMinBox.Text, out number))
            {
                addProdMinBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addProdMinBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            saveBtn.Enabled = allowSave();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addProductGrid2.SelectedRows)
            {
                addProductGrid2.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Deleted Part");
        }



        //private void display()
        //{
        //    dataGridView1.AutoGenerateColumns = true;
        //    dataGridView1.DataSource = Inventory.Parts;
        //    dataGridView1.ClearSelection();
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Inx = dataGridView1.CurrentCell.RowIndex;
        //    Inx = e.RowIndex;
        //}


        //private void formatPartDGV(DataGridView dp)
        //{
        //    dp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dp.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        //    dp.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        //    dp.RowHeadersVisible = false;
        //    //d.AutoSizeColumnsModel = fill; done in design mode
        //}

    }
}
