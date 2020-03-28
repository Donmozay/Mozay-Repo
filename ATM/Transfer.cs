using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Transfer : Recharge
    {
        public int pin { get; set; }
        public int amount { get; set; }
        public string accountNumber { get; set; }

    }
}
