using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartMed.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartMed.Model
{
    public class TbMedication : BaseClass, IMedicatiions
    {

        [Required(ErrorMessage = "Nome do medicamento obrigatório")]
        public string Name { get; set; }

                
        [Range(1,99999999)]
        public int quantity { get; set; }



    }
}
