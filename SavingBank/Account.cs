using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingBank
{
    internal class Account
    {
        public int accno { get; set; }
        public string name { get; set; }
        public double balance { get; set; }
        public int pinNumber { get; set; }
        public bool isActive { get; set; }
        public string openingDate { get; set; }
        public string closingDate { get; set; }
    }
}
