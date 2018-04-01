using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_8CoinToss
{
    public partial class CoinToss : Form
    {
        public CoinToss()
        {
            InitializeComponent();
        }

        private void CoinToss_Load(object sender, EventArgs e)
        {

        }

        private void tossBTN_Click(object sender, EventArgs e)
        {

            {
                // variable to indicate which side is up 
                int sideUp;

                //Create a Random object
                Random rand = new Random();

                //Get a random interger in the range of 0 through 1.
                //0 means tails up, 1 means heads up.
                sideUp = rand.Next(2);

                //Display the side that is up
                if (sideUp == 0)
                {
                    //Display tails up
                    tailsPictureBox.Visible = true;
                    headsPictureBox.Visible = false;

                }
                else
                {
                    //display heads up.
                    headsPictureBox.Visible = true;
                    tailsPictureBox.Visible = false;

                }


            }
        }
    }
}

