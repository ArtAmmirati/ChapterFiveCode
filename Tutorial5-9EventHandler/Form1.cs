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

namespace Tutorial5_9EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        
            try
            {
                //declare a variable to hold a country name
                string countryName;

                //Declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get a StreamReader object.
               InputFile = File.OpenText()

                //Read the file's contents
                while(!inputFile.EndOfStream)
                {

                }
            }
        }
    }
}
