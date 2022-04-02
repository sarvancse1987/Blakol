using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    abstract class SalesTax
    {
        public abstract bool IsApplicable(Blakol_Product item);
        abstract public decimal Rate { get; }

        public decimal Calculate(Blakol_Product item)
        {
            if (IsApplicable(item))
            {
                //sales tax are that for a tax rate of n%, a shelf price of p contains (np/100)
                var tax = (item.ShelfPrice * Rate) / 100;

                //The rounding rules: rounded up to the nearest 0.05
                tax = Math.Ceiling(tax / 0.05m) * 0.05m;

                return tax;
            }

            return 0;
        }
    }

    class ImportedDutySalesTax : SalesTax
    {
        public override bool IsApplicable(Blakol_Product item)
        {
            return item.IsImported;
        }

        public override decimal Rate { get { return 5.00M; } }
    }
}
