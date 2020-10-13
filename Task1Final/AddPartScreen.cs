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
    public partial class AddPartScreen : Form
    {
        bool inHouse;
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        private bool allowSave()
        {
            int number;
            return 
                (!(string.IsNullOrWhiteSpace(addPartInvBox.Text) || (inHouse && !Int32.TryParse(addPartInvBox.Text, out number)))) &&
                (!(string.IsNullOrWhiteSpace(addPartPriceBox.Text) || (inHouse && !Int32.TryParse(addPartPriceBox.Text, out number)))) &&
                (!(string.IsNullOrWhiteSpace(addPartMaxBox.Text) || (inHouse && !Int32.TryParse(addPartMaxBox.Text, out number)))) &&
                (!(string.IsNullOrWhiteSpace(addPartMinBox.Text) || (inHouse && !Int32.TryParse(addPartMinBox.Text, out number)))) &&
                (!(string.IsNullOrWhiteSpace(addPartNameBox.Text))) &&
                (!(string.IsNullOrWhiteSpace(addPartMachComBox.Text) || (inHouse && !Int32.TryParse(addPartMachComBox.Text, out number))))
                ;
        }
        public AddPartScreen()
        {
            InitializeComponent();

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (AddPartMaxBoxText < AddPartMinBoxText)
            {
                MessageBox.Show("Minimum canot be greater than the Maximum");
                return;
            }
            if ((AddPartMaxBoxText < AddPartInvBoxText) ^ (AddPartInvBoxText < AddPartMinBoxText))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }
            if (InHouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMinBoxText, AddPartMaxBoxText, int.Parse(AddPartMachComBoxText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutSourcedPart outSourced = new OutSourcedPart((Inventory.Parts.Count + 1), AddPartNameBoxText, AddPartInvBoxText, AddPartPriceBoxText, AddPartMinBoxText, AddPartMaxBoxText, AddPartMachComBoxText);
                Inventory.AddPart(outSourced);
            }
            this.Hide();
            MainForm.mainPartsGrid.Refresh();
            MainForm.mainProductsGrid.Refresh();
        }
        private void InHouse_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
            addPartMachComBox.Text = "Mach ID";
            inHouse = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
            addPartMachComBox.Text = "Comp Nm";
            inHouse = false;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void addPartIDBoxText_TextChanged(object sender, EventArgs e)
        //{
        //    int number;
        //    if (string.IsNullOrWhiteSpace(addPartIDBoxText.Text) || !Int32.TryParse(addPartIDBoxText.Text, out number))
        //    {
        //        addPartIDBoxText.BackColor = System.Drawing.Color.Salmon;
        //    }
        //    else
        //    {
        //        addPartIDBoxText.BackColor = System.Drawing.Color.AliceBlue;
        //    }
        //    sendButton.Enabled = allowSave();
        //}

        private void addPartNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartNameBox.Text))
            {
                addPartNameBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartNameBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }
        private void addPartInvBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addPartInvBox.Text) || !Int32.TryParse(addPartInvBox.Text, out number)) 
            {
                addPartInvBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartInvBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }

        private void addPartPriceBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addPartPriceBox.Text) || !Int32.TryParse(addPartPriceBox.Text, out number))
            {
                addPartPriceBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartPriceBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }

        private void addPartMaxBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addPartMaxBox.Text) || !Int32.TryParse(addPartMaxBox.Text, out number))
            {
                addPartMaxBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMaxBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }

        private void addPartMinBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addPartMinBox.Text) || !Int32.TryParse(addPartMinBox.Text, out number))
            {
                addPartMinBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMinBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }

        private void addPartMachComBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(addPartMachComBox.Text) || !Int32.TryParse(addPartMachComBox.Text, out number))
            {
                addPartMinBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartMinBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            sendButton.Enabled = allowSave();
        }
    }
}
