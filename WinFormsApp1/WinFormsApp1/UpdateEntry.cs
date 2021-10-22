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
    public partial class UpdateEntry : Form
    {
        public UpdateEntry()
        {
            InitializeComponent();
            txtBoxID.MaxLength = 8;
            txtBoxFirstName.MaxLength = 20;
            txtBoxLastName.MaxLength = 20;
            txtBoxScore.MaxLength = 3;
        }

        private void UpdateEntry_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentsTable", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataUpdate.DataSource = ds.Tables["StudentsTable"].DefaultView;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd;
            if (txtBoxID.Text != "" && txtBoxFirstName.Text != ""){
                cmd = new SqlCommand($"Update StudentsTable set Firstname = '{txtBoxFirstName.Text}' where ID = '{txtBoxID.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            if (txtBoxID.Text != "" && txtBoxLastName.Text != "")
            {
                cmd = new SqlCommand($"Update StudentsTable set Lastname = '{txtBoxLastName.Text}' where ID = '{txtBoxID.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            if (txtBoxID.Text != "" && txtBoxScore.Text != "")
            {
                cmd = new SqlCommand($"Update StudentsTable set Score = '{txtBoxScore.Text}' where ID = '{txtBoxID.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentsTable", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            studentDataUpdate.DataSource = ds.Tables["StudentsTable"].DefaultView;
        }

    }
}
