using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    class ShoppringCart
    {
        public IList<ShoppringCartItem> CartItems { get; set; }

        public decimal TotalTax { get { return CartItems.Sum(x => x.Tax); } }

        public decimal TotalCost { get { return CartItems.Sum(x => x.Cost); } }
    }

    class ShoppringCartItem
    {
        public Blakol_Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Tax { get; set; }

        public decimal Cost { get { return Quantity * (Tax + Product.ShelfPrice); } }

        public override string ToString()
        {
            return string.Format("{0} {1} : {2:N2}", Quantity, Product.Name, Cost);
        }
    }
}
