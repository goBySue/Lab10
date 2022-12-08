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
        //private double newFunds;
 

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

        //public Customer(string first, string last, int num, double bal, double funds)
        //{
        //    fName = first;
        //    lName = last;
        //    acctNum = num;
        //    acctBal = bal;
        //    newFunds = funds;
        //}

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

        //public double NewFunds
        //{
        //    get { return newFunds; }
        //    set { newFunds = value; }
        //}

        public double Deposit(double amount)
        {
            if (amount > 0)
                acctBal +=amount;

            return acctBal;
        }

        public double Withdraw(double amount)
        {
            if (amount > 0)
                acctBal -= amount;

            return acctBal;
        }

        public override string ToString()
        {
            return fName + " " + lName + " " + "Updated Account Balance: " + acctBal.ToString("c");
         
        }

    }
}
