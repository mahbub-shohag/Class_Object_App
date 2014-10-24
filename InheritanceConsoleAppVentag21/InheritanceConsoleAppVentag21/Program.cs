using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleAppVentag21
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTime aPartTimeEmployee = new PartTime();
            Console.WriteLine("please insert your First Name :");
            aPartTimeEmployee.firstName = Console.ReadLine();
            Console.WriteLine("Insert your last name :");
            aPartTimeEmployee.lastName = Console.ReadLine();
            Console.WriteLine("Please insert your email :");
            aPartTimeEmployee.email = Console.ReadLine();
            Console.WriteLine("Your per hour salary :");
            aPartTimeEmployee.perHourSalary =double.Parse(Console.ReadLine());
            Console.WriteLine("your work hour :");
            aPartTimeEmployee.totalWorkHour = int.Parse(Console.ReadLine());
           // aPartTimeEmployee.Salary(aPartTimeEmployee.totalBasic(aPartTimeEmployee.perHourSalary , aPartTimeEmployee.totalWorkHour),20,30);
            Console.WriteLine(aPartTimeEmployee.Information(aPartTimeEmployee.Salary(aPartTimeEmployee.totalBasic(aPartTimeEmployee.perHourSalary, aPartTimeEmployee.totalWorkHour), 20, 30)));
            Console.ReadKey();
        }
    }
}
