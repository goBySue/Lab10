using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Customer
    {
        private string fName;
        private string lName;
        private int acctNum;
        private double acctBal;
        private double newBal;
  

        // Default constructor
        public Customer()
        {

        }

        public Customer(string first, string last, int num, double bal)
        {
            fName = first;
            lName = last;
            acctNum = num;
            acctBal = bal;
         
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public int AcctNum
        {
            get { return acctNum; }
            set { acctNum = value; }
        }

        public double AcctBal
        {
            get { return acctBal; }
            set { acctBal = value; }
        }

        public double NewBal
        {
            get { return newBal; }
            set { newBal = value; }
        }
        public double Deposit(double amount)
        {
            double newBal=0;
            if (amount > 0)
                newBal= acctBal += amount;

            return newBal;
        }

        public double Withdraw(double amount)
        {
            double newBal = 0;
            if (amount > 0)
                newBal = acctBal -= amount;

            return newBal;
        }

        public override string ToString()
        {
            return fName + " " + lName + " " + "Updated Account Balance: " + newBal.ToString("c");
         
        }

    }
}
