using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMed.Interfaces
{
    public interface IMedicatiions
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
       
    }
}
