using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Product_Shop
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            string input;

            while ((input = Console.ReadLine())?.ToLower() != "revision")
            {
                var data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var shopName = data[0];
                var product = data[1];
                var price = double.Parse(data[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                }

                if (!shops[shopName].ContainsKey(product))
                {
                    shops[shopName][product] = 0;
                }

                shops[shopName][product] = price;
            }

            foreach (var shop in shops)
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
