// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{

    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        //constant
        const int PER_HR_SALARY = 20;
        //declaration and initilization
        int totalSalary = 0;
        int totalHr = 0;
        int[] dailyWageArray = new int[20];
        Dictionary<int, int> dailyWageDict = new Dictionary<int, int>();

        for (int day = 0; day < 20; day++)
        {


            int workingHr = GetWorkingHr();

            if (totalHr >= 100)
            {
                break;
            }
            int salary = PER_HR_SALARY * workingHr;
            totalSalary = totalSalary + salary;
            totalHr = totalHr + workingHr;

            dailyWageArray[day] = salary;
            dailyWageDict[day] = salary;
            //dailyWageDict.Add(day, salary);

        }
        Console.WriteLine($"Total Salary: {totalSalary}");
        Console.WriteLine($"Total working hours: {totalHr}");
        //Console.WriteLine(String.Join(" ", dailyWageArray));

        for (int i = 0; i < 20; i++)
        {
            //Console.WriteLine($"day {i}  wage {dailyWageArray[i]}");
            Console.WriteLine($"day {i}  wage {dailyWageDict[i]}");

        }

    }



    public static int GetWorkingHr()
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

            case 0:
                workingHr = ABSENT;
                break;
            case PRESENT:
                workingHr = 8;
                break;
            case 2:
                workingHr = PART_TIME;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        return workingHr;

    }


}




