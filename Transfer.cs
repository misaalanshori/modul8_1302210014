using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302210014
{
    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set;}

        public Transfer() { }
        public Transfer(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}
