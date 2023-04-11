using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302210014
{
    public class ConfirmationText
    {
        public string en { get; set; }
        public string id { get; set; }

        public ConfirmationText() { }

        public ConfirmationText(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
