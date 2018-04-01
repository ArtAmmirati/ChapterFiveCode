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

namespace Tutorial5_6
{
    public partial class southAmerica : Form
    {
        public southAmerica()
        {
            InitializeComponent();
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void getCountriesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a variable to hold a country name
                string countryName;

                //declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get a StreamReader object.
                inputFile = File.OpenText("Countries.txt");

                //Clear anything currently in the ListBox
                countriesListBox.Items.Clear();

                //Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //get a country name.
                    countryName = inputFile.ReadLine();

                    //add the country name to the ListBox
                    countriesListBox.Items.Add(countryName);

                }
                //close the file.
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
