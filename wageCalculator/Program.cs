// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        GetEmployeeWage Dmart = new GetEmployeeWage("Dmart", 20, 20, 100);
        GetEmployeeWage Reliance = new GetEmployeeWage("Reliance", 25, 22, 50);

    }
}

