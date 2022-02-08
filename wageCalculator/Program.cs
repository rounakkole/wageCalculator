// See https://aka.ms/new-console-template for more information


using System;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        Random rnd = new Random();
        int present = (rnd.Next(2));

        if (present == 0)
        {
            Console.WriteLine("employee is absent");
        }
        else
        {

            Console.WriteLine("employee is present");

        }
    }


}

