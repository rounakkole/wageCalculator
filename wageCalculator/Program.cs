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

        for (int day = 1; day <= 20; day++)
        {
            Random rnd = new Random();
            int present = (rnd.Next(3));

            switch (present)
            {

                case 0:
                    workingHr = 0;
                    break;
                case 1:
                    workingHr = 8;
                    break;
                case 2:
                    workingHr = 4;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            int salary = perHrSalary * workingHr;
            totalSalary = totalSalary + salary;
        }
            Console.WriteLine($"Total Salary {totalSalary}");


        }
    }




