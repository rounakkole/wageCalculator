// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        GetEmployeeWage getEmployeeWage = new GetEmployeeWage();
        getEmployeeWage.EmployeeWage();
    }
}

