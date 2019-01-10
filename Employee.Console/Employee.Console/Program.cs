using System;
using Employee.BL;

namespace Employee.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration empReg = new Registration();

            System.Console.WriteLine("Enter Employee Name");
            string empName = System.Console.ReadLine();

            System.Console.WriteLine("Enter Employee Role");
            string empRole = System.Console.ReadLine();

            System.Console.WriteLine("Enter Employee Age");
            int empAge = int.Parse(System.Console.ReadLine());

           if( empReg.SaveEmployee(empName, empRole, empAge))
            {
                System.Console.WriteLine("Saved the details");
            }
           else
                System.Console.WriteLine("Not Saved the details");
        }
    }
}
