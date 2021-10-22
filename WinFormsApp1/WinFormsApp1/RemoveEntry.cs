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
            removeDataChoices.Items.Add("ID");
            removeDataChoices.Items.Add("Firstname");
            removeDataChoices.Items.Add("Lastname");
            removeBox.MaxLength = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteSpecificID();
        }

        public void deleteSpecificID()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='Parallax Database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete from StudentsTable where {removeDataChoices.Text} = '" + removeBox.Text + "'", con);
            cmd.ExecuteNonQuery();
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
