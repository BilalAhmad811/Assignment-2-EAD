using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        private ArrayList FullName = new ArrayList(); 
        private List<string> subjectsList = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            bool prerequisite = checkBox1.Checked;

            FirstName = Regex.Replace(FirstName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
            LastName = Regex.Replace(LastName, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);

            FullName.Add(FirstName + " " + LastName);

            string Result = FirstName + " " + LastName +" has registered for: "+Environment.NewLine;

            string[] subjects = textBox3.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            subjectsList.AddRange(subjects);

            foreach (string subject in subjects)
            {
                Result += subject + Environment.NewLine;
            }

            Result += "Prerequisite Clear: " + prerequisite;
            label4.Text = Result;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
