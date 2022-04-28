using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartMed.Interfaces;

namespace SmartMed.Model
{
    public class ListMedications : IListMedications
    {
        public List<TbMedication> GetMedications { get; set; }
    }
}
