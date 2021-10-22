using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class StudentData : Form
    {
        public string[] studentData = new string[20];

        public StudentData()
        {
            InitializeComponent();
            studentDataChoices.Items.Add("ID");
            studentDataChoices.Items.Add("Firstname");
            studentDataChoices.Items.Add("Lastname");
            studentDataChoices.Items.Add("Score");
            searchBox.MaxLength = 30;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentsTable", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataSearch.DataSource = ds.Tables["StudentsTable"].DefaultView;
        }

        public void insertEntry(string idno, string firstName, string lastName, string Score)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into StudentsTable values('" + idno + "', '" + firstName + "', '" + lastName + "', '" + Score + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select * from StudentsTable where {studentDataChoices.Text} like '%' + '" + searchBox.Text + "' +'%'", con);
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataSearch.DataSource = ds.Tables["StudentsTable"].DefaultView;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
