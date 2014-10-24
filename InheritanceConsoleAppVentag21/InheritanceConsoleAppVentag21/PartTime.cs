using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsoleAppVentag21
{
    class PartTime : Employee
    {
        public  double perHourSalary;
        public  int totalWorkHour;
        public  double totalBasic(double phs , int twh)
        {
            return perHourSalary * totalWorkHour;
        }
        
    }
}
