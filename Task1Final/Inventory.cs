using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Final
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static int CurrentIndex { get; set; }
        public static int grid1Index { get; set; }
        public static void PopulateDummyLists()
        {
            //create dummy prods
            Product dummyProd1 = new Product(1, "Product 1", 3, 12.00m, 5, 2);
            Product dummyProd2 = new Product(2, "Product 2", 3, 8.00m, 5, 2);
            Product dummyProd3 = new Product(3, "Product 3", 3, 3m, 5, 2);
            Product dummyProd4 = new Product(4, "Product 4", 3, 7m, 5, 2);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

            // add mach ids and comp names
            Part dummyPart1A = new InHousePart(1, "Part 1.A", 5, 15.00m, 3, 10, 9001);
            Part dummyPart1B = new InHousePart(2, "Part 1.B", 5, 12.00m, 2, 10, 9001);
            Part dummyPart2A = new InHousePart(3, "Part 2.A", 6, 10.00m, 2, 10, 9002);
            Part dummyPart2B = new InHousePart(4, "Part 2.B", 7, 5.00m, 2, 10, 9002);
            Part dummyPart3A = new OutSourcedPart(5, "Part 3.A", 8, 15.00m, 2, 10, "ShopCorp");
            Part dummyPart3B = new OutSourcedPart(6, "Part 3.B", 6, 12.00m, 2, 10, "ShopCorp");
            Part dummyPart4A = new OutSourcedPart(7, "Part 4.A", 7, 10.00m, 2, 10, "PPI, LLC");
            Part dummyPart4B = new OutSourcedPart(8, "Part 4.B", 7, 5.00m, 2, 10, "PPI, LLC");

            Parts.Add(dummyPart1A);
            Parts.Add(dummyPart1B);
            Parts.Add(dummyPart2A);
            Parts.Add(dummyPart2B);
            Parts.Add(dummyPart3A);
            Parts.Add(dummyPart3B);
            Parts.Add(dummyPart4A);
            Parts.Add(dummyPart4B);

            // Add parts to assicated products
            dummyProd1.AssociatedParts.Add(dummyPart1A);
            dummyProd1.AssociatedParts.Add(dummyPart1B);
            dummyProd2.AssociatedParts.Add(dummyPart2A);
            dummyProd2.AssociatedParts.Add(dummyPart2B);
            dummyProd3.AssociatedParts.Add(dummyPart3A);
            dummyProd3.AssociatedParts.Add(dummyPart3B);
            dummyProd4.AssociatedParts.Add(dummyPart4A);
            dummyProd4.AssociatedParts.Add(dummyPart4B);
        }
        //add
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        //remove
        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Remove Failed.");
                    return false;
                }
            }
            return success;
        }

        //lookup

        //look up part
        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
                //else
                //{
                //    return null;
                //}
            }
            return null;
        }
        //lookup product
        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            return null;
            //Product emptyProd = new Task1Final.Product();
            //return emptyProd;
        }

        public static void UpdateProduct(int productID, Product updatedProd)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.ProductName = updatedProd.ProductName;
                    currentProd.ProductInventory = updatedProd.ProductInventory;
                    currentProd.Price = updatedProd.Price;
                    currentProd.Max = updatedProd.Max;
                    currentProd.Min = updatedProd.Min;
                    currentProd.AssociatedParts = updatedProd.AssociatedParts;
                    return;
                }
            }
            //Products.Insert(CurrentIndex, updatedProd);
            //Products.RemoveAt(CurrentIndex + 1);
        }

        //parts to prods
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public static void UpdatePart(int partID, Part part)
        //{
        //    foreach (Part p in Parts)
        //    {
        //        if (p.PartID == partID)
        //        { //index here compared to current prod
        //            p.PartID = part.PartID;
        //            p.PartName = part.PartName;
        //            p.Price = part.Price;
        //            p.PartInventory = part.PartInventory;
        //            p.Min = part.Min;
        //            p.Max = part.Max;
        //            return;
        //        }
        //    }
        //}

        //above works

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }

        //below is testing

        //pass tmpi or o here. dnot care about type. goign to swap it out.  figure uot how to swap them for the part
        //public static void UpdateInHousePart(int partID, InHousePart inPart)

        //public static void UpdatePart(int partID, Part part)
        //{
        //    if (Inventory.Parts[Inventory.grid1Index].GetType() == typeof(InHousePart))
        //    {
        //        foreach (InHousePart p in Parts)
        //        {
        //            if (p.PartID == partID)
        //            { //index here compared to current prod
        //                p.PartID = part.PartID;
        //                p.PartName = part.PartName;
        //                p.Price = part.Price;
        //                p.PartInventory = part.PartInventory;
        //                p.Min = part.Min;
        //                p.Max = part.Max;
        //                p.MachineID = part.InHousePart.MachineID;
        //                return;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < Parts.Count; i++)
        //        {
        //            if (Parts[i].GetType() == typeof(Task1Final.InHousePart))
        //            {
        //                Part newPart = (InHousePart)Parts[i];

        //                if (newPart.PartID == partID)
        //                {
        //                    newPart.PartName = inPart.PartName;
        //                    newPart.PartInventory = inPart.PartInventory;
        //                    newPart.Price = inPart.Price;
        //                    newPart.Max = inPart.Max;
        //                    newPart.Min = inPart.Min;
        //                    newPart.MachineID = inPart.MachineID;
        //                }
        //            }
        //        }
        //    }

        ////public static void UpdatedOutsourcedPart(int partID, OutSourcedPart outPart)
        //{
        //    for (int i = 0; i < Parts.Count; i++)
        //    {
        //        if (Parts[i].GetType() == typeof(Task1Final.OutSourcedPart))
        //        {
        //            OutSourcedPart newPart = (OutSourcedPart)Parts[i];

        //            if (newPart.PartID == partID)
        //            {
        //                newPart.PartName = outPart.PartName;
        //                newPart.PartInventory = outPart.PartInventory;
        //                newPart.Price = outPart.Price;
        //                newPart.Max = outPart.Max;
        //                newPart.Min = outPart.Min;
        //                newPart.CompanyName = outPart.CompanyName;
        //            }
        //        }
        //    }
        //}
        //}
    }
}
