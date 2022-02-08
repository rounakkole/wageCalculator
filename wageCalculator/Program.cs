// See https://aka.ms/new-console-template for more information


using System;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        int workingHr = 0;
        int perHrSalary = 20;
        int totalSalary = 0;

        Random rnd = new Random();
        int present = (rnd.Next(3));

        switch (present)
        {

            case 0:
                Console.WriteLine("Employee is absent");
                workingHr = 0;
                break;
            case 1:
                Console.WriteLine("Employee is present");
                workingHr = 8;
                break;
            case 2:
                Console.WriteLine("Employee is part time present");
                workingHr = 4;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        int salary = perHrSalary * workingHr;
        totalSalary = totalSalary + salary;
        Console.WriteLine($"Total Salary {totalSalary}");


    }
}




