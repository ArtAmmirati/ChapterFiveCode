using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_8Coins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossBTN_Click(object sender, EventArgs e)
        {
            //Variable to indicate which side is up
            int sideUP;

            //Create a Random object.
            Random rand = new Random();

            //get a randon integer in the range of 0 through 1
            // 0 means tails up, 1 means heads up
            sideUP = rand.Next(2);

            //Display the side that is up.
            if (sideUP == 0)
            {
                //display tails up.
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;

            }
            else
            {
                //Display heads up.
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
            

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}
