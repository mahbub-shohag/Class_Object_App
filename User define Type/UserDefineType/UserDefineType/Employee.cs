using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineType
{
    class Employee
    {
        private string customerName;
        private string customerID;
        double balance;
        double amount;

        public double Amount
        {
            get { return balance; }
            set { amount = value; }
        }
        public Employee(string name,string id)
        {
            customerName = name;
            customerID = id;
        }
        private void Deposit()
        {
            balance -= amount;
        }
        private void Withdraw()
        {
            balance += amount;
        }
        

    }
}
