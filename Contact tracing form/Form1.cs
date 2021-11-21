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
            ctf = File.AppendText(@"C:\\Example\Contact_Tracing_Form.txt");
            ctf.WriteLine("Mercury Drugs Contact Tracing Form");
            ctf.WriteLine("");
            ctf.WriteLine("Full Name: " + nametxt.Text);
            ctf.WriteLine("Home Address: " + addresstxt.Text);
            ctf.WriteLine("Email Address: " + emailtxt.Text);
            ctf.WriteLine("Contact Number: " + contacttxt.Text);
            ctf.WriteLine("");
            ctf.WriteLine("COVID-19 Health Check");
            ctf.WriteLine("");
            
            if(yes1.CheckState == CheckState.Checked)
            {
                ctf.WriteLine("Have you been outside of the country lately?: YES");
            } else
            {
                ctf.WriteLine("Have you been outside of the country lately?: NO");
            }

            if(yes2.CheckState == CheckState.Checked)
            {
                ctf.WriteLine("Have you been in contact with a person with COVID-19 lately?: YES");
            } else
            {
                ctf.WriteLine("Have you been in contact with a person with COVID-19 lately?: NO");
            }

            if (yes3.CheckState == CheckState.Checked)
            {
                ctf.WriteLine("Are you feeling any sickness for the past few days?: YES");
            }
            else
            {
                ctf.WriteLine("Are you feeling any sickness for the past few days?: NO");
            }

            if (yes4.CheckState == CheckState.Checked)
            {
                ctf.WriteLine("Are you vaccinated?: YES");
            }
            else
            {
                ctf.WriteLine("Are you vaccinated?: NO");
            }

            if (yes5.CheckState == CheckState.Checked)
            {
                ctf.WriteLine("Have you been Diagnosed with COVID-19?: YES");
            }
            else
            {
                ctf.WriteLine("Have you been Diagnosed with COVID-19?: NO");
            }
            
            ctf.WriteLine("__________________________________________________");
            ctf.WriteLine("");
            ctf.Close();

            MessageBox.Show("Form Submitted!");

        }


    }
}
