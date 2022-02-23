// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        IAddDetails addCompanyDetails = new GetEmployeeWage();
        addCompanyDetails.addEmployeeWage("Dmart", 20, 20, 100);
        addCompanyDetails.addEmployeeWage("Reliance", 25, 22, 100);
        addCompanyDetails.GetEmpWage();

    }
}

