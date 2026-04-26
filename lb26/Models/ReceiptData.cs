using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb26.Models
{
    public class ReceiptData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Account { get; set; }

        public double Volume { get; set; }   // м³
        public double Tariff { get; set; }   // грн за м³

        public double Total
        {
            get { return Volume * Tariff; }
        }

        public string Date => DateTime.Now.ToShortDateString();
    }
}
