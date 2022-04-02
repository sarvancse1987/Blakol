using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blakol_SalesTax
{
    public static class Blakol_Input
    {
        public static void ProcessInput(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var shoppringCart = ItemParser.Parse(input);

            var taxCalculator = new TaxCalculator();
            taxCalculator.Calculate(shoppringCart);
            ShopingCartPrinter.Print(shoppringCart);
        }
    }

    class Blakol_Product
    {

        private static readonly IDictionary<ProductType, string[]> itemType_Identifiers = new Dictionary<ProductType, string[]>
        {
            {ProductType.Food, new[]{ "chocolate", "chocolates" }},
            {ProductType.Medical, new[]{ "pills" }},
            {ProductType.Book, new[]{ "book" }}
        };

        public decimal ShelfPrice { get; set; }

        public string Name { get; set; }

        public bool IsImported { get { return Name.Contains("imported "); } }

        public bool IsTypeOf(ProductType productType)
        {
            return itemType_Identifiers.ContainsKey(productType) &&
                itemType_Identifiers[productType].Any(x => Name.Contains(x));
        }

        public override string ToString()
        {
            return string.Format("{0} at {1}", Name, ShelfPrice);
        }
    }
}
