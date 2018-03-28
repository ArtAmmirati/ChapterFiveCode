using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_3forLoop
{
    public partial class speedConverter : Form
    {
        public speedConverter()
        {
            InitializeComponent();
        }

        private void displayBTN_Click(object sender, EventArgs e)
        {

            try
            {
                //constants
                const int START_SPEED = 60;
                const int END_SPEED = 130;
                const int INTERVAL = 10;
                const double CONVERSION_FACTOR = 0.6214;

                //variables
                int kph;        //Kilometers per hour
                double mph;     //Miles per hour

                // display the table of speeds
                for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
                {
                    //calculate miles per hour
                    mph = kph * CONVERSION_FACTOR;

                    //display the  conversion
                    outputListBox.Items.Add(kph + "  KPH is the same as " +
                        mph.ToString ("n2") + " MPH");
                }

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
