namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BankAccount method
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountNumber = "9543-9876-87666";

            bankAccount.Deposit(5000);
            bankAccount.Withdraw(2000);

            Console.ReadLine();

            //Employeee SALARY calculator

            double baseSalary = 50000;

            //  polymorphism
            Employee manager = new Manager();
            manager.Name = "Manager";
            manager.BaseSalary = baseSalary;

            Employee developer = new Developer();
            developer.Name = "Developer";
            developer.BaseSalary = baseSalary;

            Console.WriteLine("Manager Salary : " + manager.CalculateSalary());
            Console.WriteLine("Developer Salary : " + developer.CalculateSalary());

            Console.ReadLine();

            //Vehicle Rental System

            int rentalDays = 3;

            Vehicle car = new Car();
            car.Brand = "Volkswagen";
            car.RentalRatePerDay = 2000;

            Console.WriteLine("Car Total Rent to be paid: " + car.CalculateRental(rentalDays));

            Vehicle bike = new Bike();
            bike.Brand = "RoyalEnfield";
            bike.RentalRatePerDay = 1000;

            Console.WriteLine("Bike Total Rent to be Paid: : " + bike.CalculateRental(rentalDays));

            Console.ReadLine();


            //Online Cart system 

            Product ep = new Electronics();
            ep.Name = "Laptop";
            ep.Price = 20000;

            Console.WriteLine("Total Price after 5% discount : " + ep.CalculateDiscount());

            Product cp = new Clothing();
            cp.Name = "Hoodie";
            cp.Price = 3000;

            Console.WriteLine("Total Price after 15% discount : " + cp.CalculateDiscount());











        }





}
}
