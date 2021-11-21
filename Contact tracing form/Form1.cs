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

namespace Contact_tracing_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter ctf;
            ctf = File.CreateText(@"C:\\Example\Contact_Tracing_Form.txt");
            ctf.WriteLine("Mercury Drugs Contact Tracing Form");
            ctf.WriteLine("");
            ctf.WriteLine("Full Name: " + nametxt.Text);
            ctf.WriteLine("Home Address: " + addresstxt.Text);
            ctf.WriteLine("Email Address: " + emailtxt.Text);
            ctf.WriteLine("Contact Number: " + contacttxt.Text);
            ctf.WriteLine("");
            ctf.WriteLine("COVID-19 Health Check");
            ctf.WriteLine("");
            
            
            
            
            
            
            ctf.Close();

        }
    }
}
