using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb25.Models
{
    public class Service
    {
        public int Id { get; set; }           
        public string ServiceName { get; set; }  
        public decimal Price { get; set; }   

        public override string ToString()
        {
            return $"{ServiceName} - {Price} грн";
        }
    }
}
