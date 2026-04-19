namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());


            //Calculator calculation = new Calculator();

            //Console.WriteLine("Addition : " + calculation.Add(a, b));
            //Console.WriteLine("Subtraction:  " + calculation.Sub(a, b));
            //Console.WriteLine("Multiplication: " + calculation.Multiply(a, b));
            //Console.WriteLine("Division:" + calculation.Divide(a, b));




            //------------------------------------------------------------------------------------------------------------------------------



            Console.Write("Enter Student marks-1: ");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Student marks-2: ");
            int m2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Student marks-3: ");
            int m3 = int.Parse(Console.ReadLine());

            studentGrade s = new studentGrade();

            double average = s.CalculateAverage(m1, m2, m3);

            if (average != -1)
            {
                string grade = s.Grade(average);

                Console.WriteLine("Average: " + average);
                Console.WriteLine("Grade: " + grade);



                //-----------------------------------------------------------------------------------------------
                Console.WriteLine("Enter Product Id: ");
                int id = int.Parse(Console.ReadLine());

                ProductDetails p = new ProductDetails(id);

                Console.WriteLine("Enter Product Name: ");
                p.ProductName = Console.ReadLine();

                Console.WriteLine("Enter Unit Price: ");
                p.UnitPrice = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Quantity: ");
                p.Quantity = int.Parse(Console.ReadLine());

                p.ShowDetails();
            }




}

}
}
