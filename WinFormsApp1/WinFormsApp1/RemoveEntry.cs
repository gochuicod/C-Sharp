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
    public partial class RemoveEntry : Form
    {
        public RemoveEntry()
        {
            InitializeComponent();
            removeBox.MaxLength = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteSpecificID();
        }

        public void deleteSpecificID()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd, cmd1;
            cmd = new SqlCommand($"Delete from StudentsTable where ID = '{removeBox.Text}'", con);
            cmd1 = new SqlCommand($"Delete from StudentScores where ID = '{removeBox.Text}'",con);
            cmd.ExecuteNonQuery(); cmd1.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentsTable", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataRemove.DataSource = ds.Tables["StudentsTable"].DefaultView;
        }

        private void RemoveEntry_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentsTable", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataRemove.DataSource = ds.Tables["StudentsTable"].DefaultView;
        }
    }
}
