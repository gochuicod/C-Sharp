using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text, lastName = textBox2.Text, idno = textBox3.Text, Score = textBox4.Text;
            int idNo;
            float score;

            if (idno != "") idNo = int.Parse(idno);
            else idNo = 12345678;
            if (Score != "") score = int.Parse(Score);
            else score = 70;

            if (firstName == "") firstName = "John";
            if (lastName == "") lastName = "Doe";

            richTextBox1.Text = $"Name: {firstName} {lastName}\nID No: {idNo}\nScore: {score}\nRemark: {gradeRemark(score)}";
        }

        public enum Remark : int
        {
            poor = 1, fair = 2, good = 3, excellent = 4
        }

        public string gradeRemark(float grade)
        {
            if (grade < 80) return (Remark.poor).ToString();
            if (grade > 79 && grade < 90) return (Remark.fair).ToString();
            if (grade > 89 && grade < 100) return (Remark.good).ToString();
            if (grade == 100) return (Remark.excellent).ToString();
            return "";
        }
    }
}
