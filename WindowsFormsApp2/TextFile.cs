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

namespace WindowsFormsApp2
{
    public partial class TextFile : Form
    {
        public TextFile()
        {
            InitializeComponent();
        }

        private void nameBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                //Create a file and get a StreamWriter object
                outputFile = File.CreateText("Friend.txt");

                //Write the friend's name to the file
                outputFile.WriteLine(nameTextBox.Text);

                //Close the file
                outputFile.Close();

                //Let the user know the name was written.
                MessageBox.Show("The Name was Written");
            }
            catch(Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
