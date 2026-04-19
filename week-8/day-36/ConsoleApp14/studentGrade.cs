using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal class studentGrade
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            if (m1 < 0 || m2 < 0 || m3 < 0)
            {
                Console.WriteLine("Marks cannot be negative Values!!");
                return -1; 
            }

            return (m1 + m2 + m3) / 3.0;
        }

        public string Grade(double avg)
        {
            if (avg == -1)
                return "Invalid";

            if (avg >= 85)
                return "A";
            else if (avg >= 65)
                return "B";
            else if (avg >= 55)
                return "C";
            else
                return "F";
        }


    }
}
