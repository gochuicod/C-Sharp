using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerWindowsApp
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student studentObject = new Student();
            studentObject.Id = textBox1.Text;
            studentObject.Firstname = textBox2.Text;
            studentObject.Lastname = textBox3.Text;
            studentObject.Quizscore = textBox4.Text;
            studentObject.Remarks = textBox5.Text;
           


            listBoxResults.Items.Add(studentObject.Id);
            listBoxResults.Items.Add(studentObject.Firstname);
            listBoxResults.Items.Add(studentObject.Lastname);
            listBoxResults.Items.Add(studentObject.Quizscore);
            listBoxResults.Items.Add(studentObject.Remarks);

           
          
        }

       
    }
}
