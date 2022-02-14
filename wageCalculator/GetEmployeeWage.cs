using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wageCalculator
{
    internal class GetEmployeeWage
    {
        public void EmployeeWage()
        {
            //constant
            const int PER_HR_SALARY = 20;
            const int MAX_DAYS = 20;

            //declaration and initilization
            int totalSalary = 0;
            int totalHr = 0;
            Dictionary<int, int> dailyWageDict = new Dictionary<int, int>();

            for (int day = 0; day < MAX_DAYS; day++)
            {
                int workingHr = GetWorkingHr();
                int salary = PER_HR_SALARY * workingHr;
                totalSalary = totalSalary + salary;
                totalHr = totalHr + workingHr;
                dailyWageDict.Add(day, salary);
                if (totalHr >= 100)
                {
                    break;
                }

            }
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Total working hours: {totalHr}");
            //Console.WriteLine(String.Join(" ", dailyWageArray));

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"day {i + 1}  wage {dailyWageDict[i]}");

            }
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
