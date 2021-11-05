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
    public partial class StudentScores : Form
    {
        public StudentScores()
        {
            InitializeComponent();
        }

        private void LastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select StudentsTable.Firstname, StudentsTable.Lastname, StudentsTable.Score from StudentsTable Inner Join StudentScores on StudentsTable.ID = StudentScores.ID and StudentsTable.ID like '%{LastnameTextBox.Text}%'", con);
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            StudentScoresTable.DataSource = ds.Tables["StudentsTable"].DefaultView;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
