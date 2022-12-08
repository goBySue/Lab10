using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            txtBxName.Enabled = false;
            txtBxAcctNum.Enabled = false;
            txtBxOriDeposit.Enabled = false;

            lblDeposit.Visible = true;
            lblWithdraw.Visible = true;
            txtBxAddDep.Visible = true;
            txtBxWithdraw.Visible = true;
            btnUpdate.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;
            txtBxAddDep.Visible = false;
            txtBxWithdraw.Visible = false;

            lblNewBal.Visible = true;
            txtBxNewBal.Visible = true;

            int acctNum;
            double origDeposit, amount;
            string[] name = new string[2];

            while (double.TryParse(txtBxOriDeposit.Text, out origDeposit) == false)
            {
                MessageBox.Show("Numeric value should be entered for Original Deposit");
                txtBxOriDeposit.Text = "0";
                txtBxOriDeposit.Focus();

            }
            if (int.TryParse(txtBxAcctNum.Text, out acctNum) == false)
            {
                MessageBox.Show("Numeric value should be entered for Account Number");
                txtBxAcctNum.Text = "0";
                txtBxAcctNum.Focus();
            }

            name = txtBxName.Text.Split(' ');
            if (name.Length < 2)
            {
                txtBxName.Text = "Please enter full name";
                txtBxName.Focus();
            }

            else
            {
            
                Customer cust = new Customer(name[0], name[1], acctNum, origDeposit);

                try
                {
                    StreamWriter fil = new StreamWriter("BankingInfo.txt", true);
                    fil.WriteLine(cust);
                    MessageBox.Show("New account balance has been successfully upated");
                    fil.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }


                if (double.TryParse(txtBxAddDep.Text, out amount) == true)
                {
                    txtBxNewBal.Text = cust.Deposit(amount).ToString("c");
                }

                else if (double.TryParse(txtBxWithdraw.Text, out amount) == true)
                {
                    txtBxNewBal.Text = cust.Withdraw(amount).ToString("c");
                }

            }
        }

    }
}

 

