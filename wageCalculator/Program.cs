// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        IAddDetails addCompanyDetails = new GetEmployeeWage(2);
        addCompanyDetails.addEmployeeWage("Dmart", 20, 20, 100);
        addCompanyDetails.addEmployeeWage("Reliance", 25, 22, 50);
        addCompanyDetails.GetEmpWage();

    }
}

