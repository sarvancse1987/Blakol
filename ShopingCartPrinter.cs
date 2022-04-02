using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    class ShopingCartPrinter
    {
        public static void Print(ShoppringCart shoppringCart)
        {
            //printe items => 1 chocolate bar: 0.85
            foreach (var cartItem in shoppringCart.CartItems)
            {
                Console.WriteLine(cartItem.ToString());
            }

            //print Sales => Taxes: 1.50
            Console.WriteLine("Taxes: {0:N2}", shoppringCart.TotalTax);

            //print => Total: 29.83
            Console.WriteLine("Total: {0:N2}", shoppringCart.TotalCost);
        }
    }
}
