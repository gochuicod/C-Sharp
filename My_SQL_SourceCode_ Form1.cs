using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_sql
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        
        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "nelsontormis123";
        String database = "studentsdb";


        public Form1()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM studentsdb.studentdata";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
                
           
        }

        //This part for Exit//
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {


                iExit = MessageBox.Show("Confirm if you want to exit", " project_sql ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //This part for Reset
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (Control c in panel4.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();

                }
                textBox6.Text = "";
                upLoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        /// This part fot Print //
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// This part for Document //
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// This part for Form1 //
        private void Form1_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        /// This part for Insert New //
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
          
              try
             {
                sqlConn.Open();
                sqlQuery = "insert into studentsdb.studentdata ( ID, FirstName, LastName, Quizscore, Remarks" +
                    " values('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "')";


                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();

                sqlConn.Close();

             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);

             }
             finally
               {
                sqlConn.Close();
               }
                upLoadData();


        }
         
        /// This part for Update //
        private void button2_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                 "password=" + password + ";" + "database=" + database;
            sqlConn.Open();

            try
            {

                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = " Update studentsdb.studentdata set ID = @ID, FirstName = @FirstName, " +
                    "LastName = @LastName, QuizScore = @QuizScore, Remarks = @Remarks, ";


                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                sqlCmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                sqlCmd.Parameters.AddWithValue("@QuizScore", textBox4.Text);
                sqlCmd.Parameters.AddWithValue("@Remarks", textBox5.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                   upLoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
           
           // Unknown //
          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

        /// This part of CellClick //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// This part of Delete //
        private void button3_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" +
                "password=" + password + ";" + "database=" + database;
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "delete from studentsdb.studentdata where ID = @ID ";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlConn.Close();

            foreach(DataGridViewRow item  in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            foreach (Control c in panel4.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

            }
            textBox6.Text = "";
            upLoadData();


        }

        /// This part of Search //
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("FirstName like '%{0}%'", textBox6.Text);
                dataGridView1.DataSource = dv.ToTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
