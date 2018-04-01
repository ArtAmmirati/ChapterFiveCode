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

namespace Tutorial5_5
{
    public partial class AppendingFile : Form
    {
        public AppendingFile()
        {
            InitializeComponent();
        }

        private void writeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a StreamWriter variable.
                StreamWriter outputFile;

                //open the friend.txt file for appending,
                //and get a StreamWriter object.
                outputFile = File.AppendText("Friend.text");

                //Write the friend's name to the file
                outputFile.WriteLine(nameTextBox.Text);

                //Close the file
                outputFile.Close();

                //Let the user know the name was written
                MessageBox.Show("The Name was Written");

                //Clear teh nameTextBoc control.
                nameTextBox.Text = "";

                //Give the focus to the nameTextBox control
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                //display an error message.
                MessageBox.Show(ex.Message);

            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
