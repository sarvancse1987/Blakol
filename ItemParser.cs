using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    class ItemParser
    {
        private static readonly string ITEM_ENTRY_REGEX = "(\\d+) ([\\w\\s]* )at (\\d+.\\d{2})";

        private static readonly string[] food_identifier = { "chocolate", "chocolates" };
        private static readonly string[] medical_identifier = { "pills" };
        private static readonly string[] book_identifier = { "book" };

        public static ShoppringCart Parse(string[] listOfItemfullDesc)
        {
            return new ShoppringCart
            {
                CartItems = listOfItemfullDesc.Select(Parse).ToList(),
            };
        }

        public static ShoppringCartItem Parse(string itemfullDesc)
        {
            var regex = new Regex(ITEM_ENTRY_REGEX);
            var match = regex.Match(itemfullDesc);
            if (match.Success)
            {
                var quantity = int.Parse(match.Groups[1].Value);
                var price = decimal.Parse(match.Groups[3].Value);

                var itemName = match.Groups[2].Value.Trim();

                var shopp = new ShoppringCartItem
                {
                    Quantity = quantity,
                    Product = new Blakol_Product { Name = itemName, ShelfPrice = price }
                };

                return shopp;
            }

            return null;
        }
    }

}
