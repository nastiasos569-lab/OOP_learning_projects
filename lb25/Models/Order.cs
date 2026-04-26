using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb25.Models
{
    public class Order
    {
        public int Id { get; set; }          
        public int ClientId { get; set; }    
        public int ServiceId { get; set; }   

        public DateTime Date { get; set; }   
        public int Quantity { get; set; }    
        public decimal Total { get; set; }   
        public string ClientName { get; set; }
        public string ServiceName { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Total} грн";
        }
    }
}
