using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleAppVentag21
{
    class Employee 
    {
       
        public string firstName;
        public string lastName;
        public string email;
        public  string Information(double salary)
        {
            return "Name : "+firstName +" "+lastName+"\n"+"Email : "+email+"\n"+"Salary :"+ salary;
        }
        public double Salary(double basic,double medicalPercentOfBasic,double houserentPercentOfBasic)
        {
            double totalSalary = basic + (basic * medicalPercentOfBasic) / 100 + (basic * houserentPercentOfBasic) / 100;
            return totalSalary;
        }

    }
}
