using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Task1Final
{
    public abstract class Part 
    {

        public int PartID { get; set; }
        public string PartName { get; set; }
        public int PartInventory { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public Part() { }

        public Part(int partID) {
            PartID = partID;
        }
        public Part (int partID, string name, int inventory, decimal price, int prtMin, int prtMax)
        {
            PartID = partID;
            PartName = name;
            PartInventory = inventory;
            Price = price;
            Min = prtMin;
            Max = prtMax;

        }
    }

    
        
}
