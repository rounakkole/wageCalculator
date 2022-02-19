using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wageCalculator
{
    internal class AddWageDetails
    {
        public string CompanyName;
        public int EmpRatePerHr;
        public int MaxDays;
        public int MaxHrs;
        int totalSalary;
        public AddWageDetails(string companyName, int empRatePerHr, int maxDays, int maxHrs)
        {
            CompanyName = companyName;
            EmpRatePerHr = empRatePerHr;
            MaxDays = maxDays;
            MaxHrs = maxHrs;
        }

        public void SetEmpWage(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }

        public string toString()
        {
            return ($"total wage of {this.CompanyName} is {this.totalSalary}");
        }
    }
}
