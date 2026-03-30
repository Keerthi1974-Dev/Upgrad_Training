using System;

namespace ConsoleApp17
{
    // Address class
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }

        public Address(string street, string city, string pinCode)
        {
            Street = street;
            City = city;
            PinCode = pinCode;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Address: {Street}, {City}, {PinCode}");
        }
    }

    // Employee class
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Address EmployeeAddress { get; set; }

        public Employee(int employeeId, string name, double salary, Address address)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
            EmployeeAddress = address;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Salary: INR.{Salary}");
            EmployeeAddress.DisplayAddress();
        }
    }
}