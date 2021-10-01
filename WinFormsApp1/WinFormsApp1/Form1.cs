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
        public List<string> data = new List<string>();
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

            string temp = $"Name: {firstName} {lastName}\nID No: {idNo}\nScore: {score}\nRemark: {gradeRemark(score)}\n\n";
            data.Add(temp);
            richTextBox1.Text = $"Name: {firstName} {lastName}\nID No: {idNo}\nScore: {score}\nRemark: {gradeRemark(score)}";
            button1.Enabled = false; 
            textBox1.Enabled = false; textBox2.Enabled = false;
            textBox3.Enabled = false; textBox4.Enabled = false;
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = "";
            textBox3.Text = ""; textBox4.Text = "";
            richTextBox1.Text = "";
            button1.Enabled = true;
            textBox1.Enabled = true; textBox2.Enabled = true;
            textBox3.Enabled = true; textBox4.Enabled = true;
        }

        Form2 f2 = new Form2();

        private void studentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] str = data.ToArray();
            f2.MinimizeBox = false;
            f2.MaximizeBox = false;
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.FormBorderStyle = FormBorderStyle.FixedDialog;
            for (int i = 0; i < str.Length; f2.studentData[i] = str[i], i++);
            f2.ShowDialog();
        }

        private void undoLastItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(data.Count > -1) data[data.Count - 1] = "";
        }
    }
}
