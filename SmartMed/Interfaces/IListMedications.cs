using System.Collections.Generic;

namespace SmartMed.Model
{
    public interface IListMedications
    {
        List<TbMedication> GetMedications { get; set; }
    }
}