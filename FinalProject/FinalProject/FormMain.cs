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

namespace FinalProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            pnlStudentEntry.Visible = false;
            pnlViewEntries.Visible = false;
            pnlUpdateEntries.Visible = false;
            pnlDeleteEntries.Visible = false;
            
            cbViewEntriesChoices.Items.Add("ID");
            cbViewEntriesChoices.Items.Add("FirstName");
            cbViewEntriesChoices.Items.Add("LastName");
            cbViewEntriesChoices.Items.Add("Grade");

            cbUpdateEntriesChoices.Items.Add("FirstName");
            cbUpdateEntriesChoices.Items.Add("LastName");
            cbUpdateEntriesChoices.Items.Add("Grade");
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            if (pnlStudentEntry.Visible == false) pnlStudentEntry.Visible = true;
            if (pnlViewEntries.Visible == true) pnlViewEntries.Visible = false;
            if (pnlUpdateEntries.Visible == true) pnlUpdateEntries.Visible = false;
            if (pnlDeleteEntries.Visible == true) pnlDeleteEntries.Visible = false;
            if (lblWelcome.Visible == true && lblStart.Visible == true) { lblWelcome.Visible = false; lblStart.Visible = false; }
            btnSubmit.Enabled = true;
            txtBoxFirstName.Enabled = true; txtBoxLastName.Enabled = true;
            txtBoxID.Enabled = true; txtBoxGrade.Enabled = true;
            txtBoxFirstName.Text = ""; txtBoxLastName.Text = ""; txtBoxID.Text = ""; txtBoxGrade.Text = "";
        }

        private void btnViewEntries_Click(object sender, EventArgs e)
        {
            if (pnlViewEntries.Visible == false) pnlViewEntries.Visible = true;
            if (pnlStudentEntry.Visible == true) pnlStudentEntry.Visible = false;
            if (pnlUpdateEntries.Visible == true) pnlUpdateEntries.Visible = false;
            if (pnlDeleteEntries.Visible == true) pnlDeleteEntries.Visible = false;
            if (lblWelcome.Visible == true && lblStart.Visible == true) { lblWelcome.Visible = false; lblStart.Visible = false; }

            SqlDataAdapter da = new SqlDataAdapter("Select * from StudentData", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsData");
            dgvViewEntries.DataSource = ds.Tables["StudentsData"].DefaultView;
        }

        private void btnUpdateEntries_Click(object sender, EventArgs e)
        {
            if (pnlViewEntries.Visible == true) pnlViewEntries.Visible = false;
            if (pnlStudentEntry.Visible == true) pnlStudentEntry.Visible = false;
            if (pnlDeleteEntries.Visible == true) pnlDeleteEntries.Visible = false;
            if (pnlUpdateEntries.Visible == false) pnlUpdateEntries.Visible = true;
            if (lblWelcome.Visible == true && lblStart.Visible == true) { lblWelcome.Visible = false; lblStart.Visible = false; }

            SqlDataAdapter da = new SqlDataAdapter("Select * from StudentData", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsData");
            dgvUpdateEntries.DataSource = ds.Tables["StudentsData"].DefaultView;
        }

        private void btnUpdateEntriesUpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd;
            if (txtBoxUpdateEntryIDBox.Text != "" && cbUpdateEntriesChoices.Text == "FirstName" && txtBoxUpdateBox.Text != "")
            {
                cmd = new SqlCommand($"Update StudentData set FirstName = '{txtBoxUpdateBox.Text}' where  ID = '{txtBoxUpdateEntryIDBox.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            if (txtBoxUpdateEntryIDBox.Text != "" && cbUpdateEntriesChoices.Text == "LastName" && txtBoxUpdateBox.Text != "")
            {
                cmd = new SqlCommand($"Update StudentData set LastName = '{txtBoxUpdateBox.Text}' where ID = '{txtBoxUpdateEntryIDBox.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            if (txtBoxUpdateEntryIDBox.Text != "" && cbUpdateEntriesChoices.Text == "Grade" && txtBoxUpdateBox.Text != "")
            {
                cmd = new SqlCommand($"Update StudentData set Grade = '{txtBoxUpdateBox.Text}' where ID = '{txtBoxUpdateEntryIDBox.Text}'", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from StudentData", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"StudentData");
            dgvUpdateEntries.DataSource = ds.Tables["StudentData"].DefaultView;
        }

        private void cbUpdateEntriesChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUpdateEntriesChoices.Text == "Grade") { txtBoxUpdateBox.MaxLength = 3; }
            else { txtBoxUpdateBox.MaxLength = 12; }
        }

        private void btnDeleteEntries_Click(object sender, EventArgs e)
        {
            if (pnlViewEntries.Visible == true) pnlViewEntries.Visible = false;
            if (pnlStudentEntry.Visible == true) pnlStudentEntry.Visible = false;
            if (pnlUpdateEntries.Visible == true) pnlUpdateEntries.Visible = false;
            if (lblWelcome.Visible == true && lblStart.Visible == true) { lblWelcome.Visible = false; lblStart.Visible = false; }
            if (pnlDeleteEntries.Visible == false) pnlDeleteEntries.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("Select ID, LastName, FirstName from StudentData", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsData");
            dgvDeleteEntries.DataSource = ds.Tables["StudentsData"].DefaultView;
        }

        private void btnDeleteEntriesDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete from StudentData where ID = '{txtBoxDeleteEntriesBox.Text}'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select ID, FirstName, LastName from StudentData", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentData");
            dgvDeleteEntries.DataSource = ds.Tables["StudentData"].DefaultView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtBoxFirstName.Text, lastName = txtBoxLastName.Text, id = txtBoxID.Text, grade = txtBoxGrade.Text;

            if (firstName == "") firstName = "John"; if (lastName == "") lastName = "Doe";
            if (id == "") id = "12345678"; if (grade == "") grade = "75";

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Insert into StudentData values('{id}','{firstName}','{lastName}','{grade}')",con);
            cmd.ExecuteNonQuery();
            con.Close();

            btnSubmit.Enabled = false;
            txtBoxFirstName.Enabled = false; txtBoxLastName.Enabled = false;
            txtBoxID.Enabled = false; txtBoxGrade.Enabled = false;
        }

        private void txtBoxViewSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinalProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand($"Select * from StudentData where {cbViewEntriesChoices.Text} like '%{txtBoxViewSearch.Text}%'", con);
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "StudentsTable");
            dgvViewEntries.DataSource = ds.Tables["StudentsTable"].DefaultView;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
