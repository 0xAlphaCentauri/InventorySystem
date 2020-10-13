using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Final
{
    public class OutSourcedPart : Part
    {
        public string CompanyName { get; set; }

        public OutSourcedPart() { }
            public OutSourcedPart(int partID, string name, int inventory, decimal price, int prtMin, int prtMax, string cName) : base (partID, name, inventory, price, prtMin, prtMax)
            {
                CompanyName = cName;
            }

        }
    }
