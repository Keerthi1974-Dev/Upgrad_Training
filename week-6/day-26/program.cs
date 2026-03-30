namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductData data = new ProductData();

            while (true)
            {
                Console.WriteLine("\n1.Insert 2.ViewAll 3.GetById 4.Update 5.Delete 6.Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Product p = new Product();

                    Console.Write("Enter Name: ");
                    p.ProductName = Console.ReadLine();

                    Console.Write("Enter Category: ");
                    p.Category = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    p.Price = decimal.Parse(Console.ReadLine());

                    data.InsertProduct(p);
                    Console.WriteLine("Inserted");
                }

                else if (choice == 2)
                {
                    data.GetAllProducts();
                }

                else if (choice == 3)
                {
                    Console.Write("Enter Product ID: ");
                    int id = int.Parse(Console.ReadLine());

                    data.GetProductById(id);
                }

                else if (choice == 4)
                {
                    Product p = new Product();

                    Console.Write("Enter ID: ");
                    p.ProductId = int.Parse(Console.ReadLine());

                    Console.Write("New Name: ");
                    p.ProductName = Console.ReadLine();

                    Console.Write("New Category: ");
                    p.Category = Console.ReadLine();

                    Console.Write("New Price: ");
                    p.Price = decimal.Parse(Console.ReadLine());

                    data.UpdateProduct(p);
                    Console.WriteLine("Updated");
                }

                else if (choice == 5)
                {
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());

                    data.DeleteProduct(id);
                    Console.WriteLine("Deleted");
                }

                else if (choice == 6)
                {
                    break;
                }



            }


            }
    }
}
