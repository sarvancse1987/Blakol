using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    class BasicSalesTax : SalesTax
    {
        private ProductType[] _taxExcemptions = new[] { ProductType.Food, ProductType.Medical, ProductType.Book };

        public override bool IsApplicable(Blakol_Product item)
        {
            return !(_taxExcemptions.Any(x => item.IsTypeOf(x)));
        }

        public override decimal Rate { get { return 10.00M; } }
    }
}
