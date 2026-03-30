using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    
        public class Vehicle {
        public string Brand { get; set; }
        public double RentalRatePerDay { get; set; }

        public virtual double CalculateRental(int days)
        {
            if (days <= 0)
            {
                return -1;
            }

            return RentalRatePerDay * days;
        }
    }


    public class Car : Vehicle
    {
        public override double CalculateRental(int days)
        {
            if (days <= 0)
            {
                return -1;
            }

            double total = RentalRatePerDay * days;
            return total + 500; // Insurance charge
        }
    }

    // Bike Class
    public class Bike : Vehicle
    {
        public override double CalculateRental(int days)
        {
            if (days <= 0)
            {
                return -1;
            }

            return (RentalRatePerDay * days) * 0.95; // 5% discount
        }
    }








}
