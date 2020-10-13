using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Final
{
        public class InHousePart : Part
        {
        public int MachineID { get; set; }


        public InHousePart() { }
            public InHousePart(int partID, string name, int inventory, decimal price, int prtMin, int prtMax, int machineID) : base (partID, name, inventory, price, prtMin, prtMax)
            {
                MachineID = machineID;
            }
        }
    
}
