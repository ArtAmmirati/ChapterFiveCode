using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial5_7RunningTotal
{
    public partial class runningTotal : Form
    {
        public runningTotal()
        {
            InitializeComponent();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                decimal sales;              //to hold a sales amount
                decimal total = 0m;         //Accumulator, set to 0

                //Declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                //Read the file;s contents
                while(!inputFile.EndOfStream)
                {
                    //get a sales amount
                    sales = decimal.Parse(inputFile.ReadLine());

                    //add the sales amount to total
                    total += sales;
                }
                //close the file.
                inputFile.Close();

                //display the total.
                totalLB.Text = total.ToString("c");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
