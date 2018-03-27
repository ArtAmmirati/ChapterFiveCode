using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndingBalance
{
    public partial class EndingBalance : Form
    {
        public EndingBalance()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            //Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            //local variables
            decimal balance;     // the account balance
            int months;          // the number of months
            int count = 1;        // loop counter, initalized with 1

            // get the starting blance
            if (decimal.TryParse(inStartingBalTB.Text, out balance))
            {
                //get the number of months
                if (int.TryParse(inMonthsTB.Text, out months))
                {
                    //the following loop calculates the ending balance
                    while (count <= months)
                    {
                        //add this month's interest to the balance
                        balance = balance + (INTEREST_RATE * balance);

                        //display this month's ending balance.
                        detailListBox.Items.Add("The ending balance" + " "+
                            "for month" + " " + count + " is  " +
                            balance.ToString("C"));

                        //add one to the loop counter.
                        count = count + 1;

                    }
                    // display the ending balance.
                    outEndBalanceLB.Text = balance.ToString("C");
                }
                else
                {
                    //invalid number of months was entered
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                // invalid starting balance was entered
                MessageBox.Show("Invalid value for starting balance.");
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            // clear the textboxes and the outending balancelabel contro
            inStartingBalTB.Text = "";
            inMonthsTB.Text = "";
            outEndBalanceLB.Text = "";
            detailListBox.Items.Clear();

            //reset the focus
            inStartingBalTB.Focus();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
