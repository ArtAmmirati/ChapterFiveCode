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

namespace Tutorial5_9LoadEvent
{
    public partial class LoadEvent : Form
    {
        public LoadEvent()
        {
            InitializeComponent();
        }

        private void LoadEvent_Load(object sender, EventArgs e)
        {
            try
            {
                //declare a variable to hold a country name.
                string countryName;

                //Declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get a StreamReader object.
                inputFile = File.OpenText("Countries.txt");

                //Read the files's contents.
                while (!inputFile.EndOfStream)
                {
                    //Get a country name.
                    countryName = inputFile.ReadLine();

                    //add the country name to the ListBox.
                    countrieListBox.Items.Add(countryName);
                }
                //close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}
