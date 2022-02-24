using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wageCalculator
{
    internal interface IAddDetails
    {
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked);
        public void GetEmpWage(string CompanyWage);
    }
}
