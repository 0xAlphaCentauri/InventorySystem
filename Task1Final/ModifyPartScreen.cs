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
    public partial class ModifyPartScreen : Form
    {
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];
        public bool isNew;
        int number;
        decimal numberD;
        private bool allowSave()
        {
            bool allowSaveZ = false;
            if (radioModInhouse.Checked)
            {

                if (!Int32.TryParse(modPartMachComBox.Text, out number))
                {
                    allowSaveZ = true;
                }
            }
            if (radioModOutsourced.Checked)
            {
                allowSaveZ = true;
            }
            return
                (!(string.IsNullOrWhiteSpace(modPartInvBox.Text) || !Int32.TryParse(modPartInvBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modPartPriceBox.Text) || !Decimal.TryParse(modPartPriceBox.Text, out numberD))) &&
                (!(string.IsNullOrWhiteSpace(modPartMinBox.Text) || !Int32.TryParse(modPartMinBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modPartMaxBox.Text) || !Int32.TryParse(modPartMaxBox.Text, out number))) &&
                (!(string.IsNullOrWhiteSpace(modPartNameBox.Text))) && (!(string.IsNullOrWhiteSpace(modPartMachComBox.Text)
                && allowSaveZ));
        }

        //public bool IsNew()
        //{
        //    if (MainScreen.gridID )
        //}

        InHousePart tmpI = new InHousePart();
        OutSourcedPart tmpO = new OutSourcedPart();

        public ModifyPartScreen()
        {
            InitializeComponent();


            ModPartIDBoxText = Inventory.Parts[Inventory.grid1Index].PartID;
            ModPartNameBoxText = Inventory.Parts[Inventory.grid1Index].PartName;
            ModPartInvBoxText = Inventory.Parts[Inventory.grid1Index].PartInventory;
            ModPartPriceBoxText = Inventory.Parts[Inventory.grid1Index].Price;
            ModPartMaxBoxText = Inventory.Parts[Inventory.grid1Index].Max;
            ModPartMinBoxText = Inventory.Parts[Inventory.grid1Index].Min;

            if (Inventory.Parts[Inventory.grid1Index].GetType() == typeof(InHousePart))
            {
                tmpI = (InHousePart)Inventory.Parts[Inventory.grid1Index];
                ModPartMachComBoxText = tmpI.MachineID.ToString();

                radioModInhouse.Checked = true;
            }
            else
            {

                tmpO = (OutSourcedPart)Inventory.Parts[Inventory.grid1Index];
                ModPartMachComBoxText = tmpO.CompanyName.ToString();
                radioModOutsourced.Checked = true;
            }

        }

        //test
        //public ModifyPartScreen(OutSourcedPart outPart)
        //{
        //    InitializeComponent();

        //    ModPartIDBoxText = outPart.PartID;
        //    ModPartNameBoxText = outPart.PartName;
        //    ModPartInvBoxText = outPart.PartInventory;
        //    ModPartPriceBoxText = outPart.Price;
        //    ModPartMaxBoxText = outPart.Max;
        //    ModPartMinBoxText = outPart.Min;
        //    ModPartMachComBoxText = outPart.CompanyName.ToString();

        //    radioModOutsourced.Checked = true;
        //}
        //save it
        private void btnModPartSave_Click(object sender, EventArgs e)
        {
            if (ModPartMaxBoxText < ModPartMinBoxText)
            {
                MessageBox.Show("Minimum cannot be greater than the maximum");
                return;
            }
            if ((ModPartMaxBoxText < ModPartInvBoxText) || (ModPartInvBoxText < ModPartMinBoxText))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }

            if ((radioModInhouse.Checked) && (!Int32.TryParse(modPartMachComBox.Text, out number))){
                MessageBox.Show("MachineID must be an integer");
                return;
            }
            if (radioModInhouse.Checked == true)
            {
                InHousePart inHouse = new InHousePart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMinBoxText, ModPartMaxBoxText, int.Parse(ModPartMachComBoxText));
                Inventory.UpdatePart(ModPartIDBoxText, inHouse);
                //radioModInhouse.Checked = true;
            }
            else
            {
                OutSourcedPart outSourced = new OutSourcedPart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMinBoxText, ModPartMaxBoxText, ModPartMachComBoxText);
                Inventory.UpdatePart(ModPartIDBoxText, outSourced);
                //radioModOutsourced.Checked = true;
            }

            //else
            //{
            //    Part updatedPart;
            //    if (radioModInhouse.Checked)
            //    {
            //        updatedPart = new InHousePart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMinBoxText, ModPartMaxBoxText, int.Parse(ModPartMachComBoxText));
            //        radioModInhouse.Checked = true;
            //    }
            //    else
            //    {
            //        updatedPart = new OutSourcedPart(ModPartIDBoxText, ModPartNameBoxText, ModPartInvBoxText, ModPartPriceBoxText, ModPartMinBoxText, ModPartMaxBoxText, ModPartMachComBoxText);
            //        radioModOutsourced.Checked = true;
            //    }
            //}
            ////Part partToSave;
            ////int tmpPartID = ModPartIDBoxText;
            ////string tmpPartName = ModPartNameBoxText;
            ////int tmpPartInventory = ModPartInvBoxText;
            ////decimal tmpPrice = ModPartPriceBoxText;
            ////int tmpMax = ModPartMaxBoxText;
            ////int tmpMin = ModPartMinBoxText;
            ////if (radioModInhouse.Checked == true)
            ////{

            ////    int machineID = Int32.Parse(ModPartMachComBoxText);
            ////    partToSave = new InHousePart();
            ////    Inventory.UpdatePart(ModPartIDBoxText, partToSave);
            ////}
            ////else if (radioModOutsourced.Checked == true)

            ////{
            ////    string cName = ModPartMachComBoxText;
            ////    partToSave = new OutSourcedPart();
            ////    Inventory.UpdatePart(ModPartIDBoxText, partToSave);
            ////}

            this.Hide();

            //MainScreen.home.Show();
            //MainForm.MainScreenFormLoad();
            //MainForm.mainPartsGrid.Update();
            MainForm.mainPartsGrid.Refresh();
            MainForm.mainProductsGrid.Refresh();
        }


        private void radioModInhouse_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
        }

        private void radioModOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
        }

        private void btnModPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainScreen.home.Show();
        }

        //check input section 
        //private void modPartIDBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(modPartIDBox.Text) || !Int32.TryParse(modPartIDBox.Text, out number))
        //    {
        //        modPartIDBox.BackColor = System.Drawing.Color.Salmon;
        //    }
        //    else
        //    {
        //        modPartIDBox.BackColor = System.Drawing.Color.AliceBlue;
        //    }
        //    btnModPartSave.Enabled = allowSave();
        //}
        private void modPartNameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartNameBox.Text))
            {
                modPartNameBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modPartNameBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            btnModPartSave.Enabled = allowSave();
        }
        private void modPartInvBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartInvBox.Text) || !Int32.TryParse(modPartInvBox.Text, out number))
            {
                modPartInvBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modPartInvBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            btnModPartSave.Enabled = allowSave();
        }

        private void modPartPriceBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartPriceBox.Text) || !Decimal.TryParse(modPartPriceBox.Text, out numberD))
            {
                modPartPriceBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modPartPriceBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            btnModPartSave.Enabled = allowSave();
        }

        private void modPartMaxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartMaxBox.Text) || !Int32.TryParse(modPartMaxBox.Text, out number))
            {
                modPartMaxBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modPartMaxBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            btnModPartSave.Enabled = allowSave();
        }

        private void modPartMinBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartMinBox.Text))
            {
                modPartMinBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modPartMinBox.BackColor = System.Drawing.Color.AliceBlue;
            }
            btnModPartSave.Enabled = allowSave();
        }

        private void modPartMachComBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(modPartMachComBox.Text))
            {
                modPartMachComBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                if (radioModInhouse.Checked)
                {
                    if (!Int32.TryParse(modPartMachComBox.Text, out number))
                    {
                        modPartMachComBox.BackColor = System.Drawing.Color.Salmon;
                    }
                    else
                    {
                        modPartMachComBox.BackColor = System.Drawing.Color.AliceBlue;
                    }
                }
                else
                    {
                        modPartMachComBox.BackColor = System.Drawing.Color.AliceBlue;
                    }

            }
            btnModPartSave.Enabled = allowSave();
        }
    }
}
