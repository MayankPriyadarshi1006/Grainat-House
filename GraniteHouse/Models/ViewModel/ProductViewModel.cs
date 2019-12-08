using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models.ViewModel
{
    public class ProductViewModel
    {
        public Product products { get; set; }
        public IEnumerable<ProductType> producttype { get; set; }
        public IEnumerable<SpecialTag> specialtags { get; set; }
    }
}
