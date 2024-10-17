using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int[] HoursWorked { get; set; }

        public double CalculateIncome()
        {
            double hourlyRate = GetHourlyRate();
            double salary = 0;

            for (int i = 0; i < HoursWorked.Length; i++)
            {
                int hours = HoursWorked[i];
                if (i > 5)
                {
                    salary += hours * hourlyRate * 2;
                }
                else
                {
                    salary += CalculateRegularIncome(hours, hourlyRate);
                }
            }
            return salary;
        }

        public double CalculateRegularIncome(int hours, double hourlyRate)
        {
            double salary = hours * hourlyRate;
            if (hours > 8)
            {
                salary += (hours - 8) * (hourlyRate + 5);
            }
            return salary;
        }
        
        public double GetHourlyRate()
        {
            if (Position == "Manager")
                return 40;
            else if (Position == "Developer")
                return 30;
            else if (Position == "Tester")
                return 20;
            else 
                return 10;
        }
    }
}    