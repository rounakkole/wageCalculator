using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace wageCalculator
{
    internal class GetEmployeeWage : IAddDetails
    {
        ArrayList CompanyArrayList = new ArrayList();
        public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked)
        {
            CompanyArrayList.Add(new AddWageDetails(companyName, wagePerHour, totalWorkingDays, maxHrsWorked));
        }
        public void GetEmpWage()
        {
     
            foreach (var employee in CompanyArrayList)
            {
                this.EmployeeWage((AddWageDetails)employee);
            }
        }
        public void EmployeeWage(AddWageDetails addWageDetails)
        {
            //declaration and initilization
            int totalSalary = 0;
            int totalHr = 0;
            //Dictionary<int, int> dailyWageDict = new Dictionary<int, int>();

            for (int day = 0; day < addWageDetails.MaxDays; day++)
            {


                int workingHr = GetWorkingHr();
                totalHr = totalHr + workingHr;
                if (totalHr >= addWageDetails.MaxHrs)
                {
                    break;
                }
                int salary = addWageDetails.EmpRatePerHr * workingHr;

                totalSalary = totalSalary + salary;
                //dailyWageDict.Add(day, salary);

            }
            /*Console.WriteLine(addWageDetails.CompanyName);
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Total working hours: {totalHr}");
            Console.WriteLine(String.Join(" ", dailyWageArray));

            for (int i = 0; i < dailyWageDict.Count; i++)
            {
                Console.WriteLine($"day {i + 1}  wage {dailyWageDict[i]}");

            }*/
            addWageDetails.SetEmpWage(totalSalary);
            Console.WriteLine(addWageDetails.toString());
        }


        public int GetWorkingHr()
        {
            //constant
            const int ABSENT = 0;
            const int PRESENT = 1;
            const int PART_TIME = 2;
            //declaration and initilization
            int workingHr = 0;

            Random rnd = new Random();
            int present = (rnd.Next(3));
            switch (present)
            {

                case ABSENT:
                    workingHr = 0;
                    break;
                case PRESENT:
                    workingHr = 8;
                    break;
                case PART_TIME:
                    workingHr = 4;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            return workingHr;
        }
    }
}
