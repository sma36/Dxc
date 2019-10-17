using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
      class AccountDetails
     {
        string name;
        int id;
        double balance;


        public void Details(string name, int id, double balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        public bool checkId(int id)
        {
            if (this.id == id)
                return true;
            else
                return false;
        }
        public string getName() { return this.name; }

        public int getId() { return this.id; }

        public double getBalance() { return this.balance; }

        public void depositAmount(double deposit)
        {
            this.balance += deposit;
        }

        public void withdrawalAmount(double withdraw)
        {
            this.balance -= withdraw;
        }
    }
}
