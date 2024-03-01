using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miravil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int days = 0; days <= 31; days++)
            {
                days = comboBox1.Items.Add(days);
            }
            for (int year = DateTime.Now.Year; year >= 1900; year--)
            {
                comboBox3.Items.Add(year);
            }
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }
            string[] courses = new string[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information System", "Bachelor of Science in Computer Engineering" };

            foreach (string course in courses)
            {
                comboBox4.Items.Add(course);
            }
            

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = textBox2.Text;
            string firstname = textBox1.Text;
            string middlename = textBox3.Text;

            string studentName = "Student Name : " + firstname + " " + middlename + " " + lastname;

            string gender = "none"; 

            if (radioButton1.Checked) 
            {
                gender = "Gender : " + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = "Gender : " + radioButton2.Text;
            }

            string DateOfBirth = "Date of birth : " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string program = "Program : " + comboBox4.Text;

            MessageBox.Show(studentName + "\n" + gender + "\n" + DateOfBirth + "\n" + program);
        }
    }
}
