using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302210014
{
    public class BankConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public ConfirmationText confirmation { get; set; }
        public BankConfig() { }
        public BankConfig(string lang, Transfer transfer, List<string> methods, ConfirmationText confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
