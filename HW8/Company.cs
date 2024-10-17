using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Company
    {
        public double CalculateTaxes(double salary, bool isLocalCompany)
        {
            double taxRate;
            if (isLocalCompany)
            {
                taxRate = 0.18;
            }
            else
            {
                taxRate = 0.5;
            }
            return salary * taxRate;
        }
    }
}