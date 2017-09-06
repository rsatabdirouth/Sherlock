using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnFinalIlds.Models.UtilityObjects
{
    public class ProductFormula
    {
        public ProductFormula()
        {
            Formula = "";
            ProductName = "";
        }
        public string Formula { get; set; }
        public string ProductName { get; set; }
    }
}
