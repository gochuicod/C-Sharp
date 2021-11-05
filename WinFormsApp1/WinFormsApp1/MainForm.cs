using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public List<string> data = new List<string>();
        public List<string> IDList = new List<string>();
        public int count = 1;
        public MainForm()
        {
            InitializeComponent();
            txtBoxFirstName.MaxLength = 20;
            txtBoxLastName.MaxLength = 20;
            txtBoxID.MaxLength = 8;
            txtBoxScore.MaxLength = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtBoxFirstName.Text, lastName = txtBoxLastName.Text, idno = txtBoxID.Text, Score = txtBoxScore.Text;

            if (idno == "") idno = "12345678";
            if (Score == "") Score = "75";

            if (firstName == "") firstName = "John";
            if (lastName == "") lastName = "Doe";

            string temp = $"Name: {firstName} {lastName}\nID No: {idno}\nScore: {Score}\nRemark: {gradeRemark(int.Parse(Score))}\n\n";
            data.Add(temp); IDList.Add(idno);
            rtxtBoxOutput.Text = $"Name: {firstName} {lastName}\nID No: {idno}\nScore: {Score}\nRemark: {gradeRemark(int.Parse(Score))}";
            btnSubmit.Enabled = false;
            txtBoxFirstName.Enabled = false; txtBoxLastName.Enabled = false;
            txtBoxID.Enabled = false; txtBoxScore.Enabled = false;
            editMenuRemoveID.Enabled = true;
            statusMenu.Text = $"{firstName} {lastName} Added!";

            StudentData f2 = new StudentData();
            f2.insertEntry(idno,firstName,lastName,Score);
            f2.insertEntry(idno);
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
            txtBoxFirstName.Text = ""; txtBoxLastName.Text = "";
            txtBoxID.Text = ""; txtBoxScore.Text = "";
            rtxtBoxOutput.Text = ""; btnSubmit.Enabled = true;
            txtBoxFirstName.Enabled = true; txtBoxLastName.Enabled = true;
            txtBoxID.Enabled = true; txtBoxScore.Enabled = true;
            statusMenu.Text = "Form Cleared";
        }

        private void studentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentData f2 = new StudentData();
            f2.MinimizeBox = false; f2.MaximizeBox = false;
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.FormBorderStyle = FormBorderStyle.FixedDialog;
            f2.ShowDialog();
        }

        private void studentScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentScores ss = new StudentScores();
            ss.MinimizeBox = false; ss.MaximizeBox = false;
            ss.StartPosition = FormStartPosition.CenterScreen;
            ss.FormBorderStyle = FormBorderStyle.FixedDialog;
            ss.ShowDialog();
        }

        private void undoLastItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEntry re = new RemoveEntry();
            re.MinimizeBox = false; re.MaximizeBox = false;
            re.StartPosition = FormStartPosition.CenterScreen;
            re.FormBorderStyle = FormBorderStyle.FixedDialog;
            re.ShowDialog();
        }

        private void editMenuUpdateEntries_Click(object sender, EventArgs e)
        {
            UpdateEntry ue = new UpdateEntry();
            ue.MinimizeBox = false; ue.MaximizeBox = false;
            ue.StartPosition = FormStartPosition.CenterScreen;
            ue.FormBorderStyle = FormBorderStyle.FixedDialog;
            ue.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
