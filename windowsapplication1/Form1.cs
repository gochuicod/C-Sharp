using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsapplication1
{
    public partial class Form1 : Form
    {
        
        public enum Remark : int
        {
            Poor = 1, Fair = 2, Good = 3, Excellent = 4,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            string FirstName = textBox1.Text,
                   LastName = textBox2.Text,
                   Idnum = textBox3.Text,
                   Score = textBox4.Text;

            int grade;
            float score;

            richTextBox1.Text  = $"Firstname: {FirstName}" +
                                $"\n Lastname: {LastName}" +
                                $"\nID No: {Idnum}" +
                                $"\nscore: {score}" +
                                $"\nRemark: {score}";
           
            switch (score)
            {
                case 1:
                    if (grade < 80)
                    {
                        Console.WriteLine("Poor");
                    }
                    break;
                case 2:
                    if (grade > 79 && grade < 90)
                    {
                        Console.WriteLine("Fair");
                    }
                    break;
                case 3:
                    if (grade > 89 && grade < 100)
                    {
                        Console.WriteLine("Good");
                    }
                    break;
                case 4:
                    if (grade == 100)
                    {
                        Console.WriteLine("Excellent");
                    }
                    break;
                    
            }

        }
    }
}

  
