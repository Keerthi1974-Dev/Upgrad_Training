using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            var products = product.GetProducts();

            // 1.Write a LINQ query to search and display all products with category “FMCG”.

            var result = products.Where(p => p.ProCategory == "FMCG").ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }

            Console.ReadLine();


            // 2. Write a LINQ query to search and display all products with category “Grain”.

            var res2 = (from p in products where p.ProCategory == "Grain" select p).ToList();

            foreach (var item in res2)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }

            // 3. Write a LINQ query to sort products in ascending order by product code.

            var res4 = (from p in products orderby p.ProCategory ascending select p).ToList();

            foreach(var item in res4)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }



            // 4. Write a LINQ query to sort products in ascending order by product Category.;
            var res = (from p in products orderby p.ProCategory ascending select p).ToList();
            foreach (var item in res)
            {
                Console.WriteLine($"{item.ProCategory}\t{item.ProName}");
            }




            // 5. Write a LINQ query to sort products in ascending order by product Mrp.

            var res6 = (from p in products orderby p.ProMrp ascending select p).ToList();

            foreach(var item in res6)
            {
                Console.WriteLine($"{item.ProMrp}\t{item.ProName}");
            }

            //6. Write a LINQ query to sort products in descending order by product Mrp
            var res7 = (from p in products orderby p.ProMrp descending select p).ToList();

            foreach(var item in res7)
            {
                Console.WriteLine($"{item.ProMrp}\t{item.ProName}");
            }

            //7. Write a LINQ query to display products group by product Category.

            var res8 = from p in products group p by p.ProCategory into g select g;

            foreach(var group in res8)
            {
                Console.WriteLine($"Category:{group.Key}");
             

                foreach(var item in group)
                {
                    Console.WriteLine(${item.ProName}\t{item.ProMrp}");
                }




            // 8.Write a LINQ query to display products group by product Mrp.


            // 9. Write a LINQ query to display product detail with highest price in FMCG category.






            //10. Write a LINQ query to display count of total products.
            var total_Products = products.Count();

            Console.WriteLine($"Total products: {total_Products}");


            //11.Write a LINQ query to display count of total products with category FMCG.
            var fmcgCount = products.Count(p => p.ProCategory == "FMCG");

            Console.WriteLine($"Total FMCG products: {fmcgCount}");

            //12.Display a LinQ query the maxPrice
            var maxPrice = products.Max(p => p.ProMrp);

            Console.WriteLine($"Max Price: {maxPrice}");

            //13.13.Write a LINQ query to display Min price.
            var minPrice = products.Min(p => p.ProMrp);

            Console.WriteLine($"Min Price: {minPrice}");

            //14. Write a LINQ query to display whether all products are below Mrp Rs.30 or not.
            var Below30 = products.All(p => p.ProMrp < 30);

            Console.WriteLine($"All products below 30: {Below30}");



            //15.Write a LINQ query to display whether any products are below Mrp Rs.30 or not.
            var anyBelow30 = products.Any(p => p.ProMrp < 30);

            Console.WriteLine($"Any product below 30: {anyBelow30}");





        }
    }
}
