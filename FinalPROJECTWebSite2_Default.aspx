using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    // Call the linq ///
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Button1_Click(object sender, EventArgs e)
    {
        var st = new MyTormisTab
        {
            ID = int.Parse(TextBox1.Text),
            Firstname = TextBox2.Text,
            Lastname = TextBox3.Text,
            Quizscore = double.Parse(TextBox4.Text),
            Remarks = TextBox5.Text,
        };
           db.MyTormisTabs.InsertOnSubmit(st);
           db.SubmitChanges();
           ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted');", true);
           LoadData();

    }
      void LoadData()
        {
            var st = from s in db.MyTormisTabs select s;
            GridView1.DataSource = st;
            GridView1.DataBind();

        }

      // this part for Update ///
    protected void Button2_Click(object sender, EventArgs e)
    {
        var st = (from s in db.MyTormisTabs where s.ID == int.Parse(TextBox1.Text) select s).First();
         st.Firstname = TextBox2.Text;
         st.Lastname = TextBox3.Text;
         st.Quizscore = double.Parse(TextBox4.Text);
         st.Remarks = TextBox5.Text;
         db.SubmitChanges();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
        LoadData();
    }

       // this part for Search ///
    protected void Button4_Click(object sender, EventArgs e)
    {
        var st = (from s in db.MyTormisTabs where s.ID == int.Parse(TextBox1.Text) select s).First();
        TextBox2.Text = st.Firstname;
        TextBox3.Text = st.Lastname;
        TextBox4.Text = st.Quizscore.ToString();
        TextBox5.Text = st.Remarks;

        LoadData();


    }

      // this part for Delete ///
    protected void Button3_Click(object sender, EventArgs e)
    {
        var st = (from s in db.MyTormisTabs where s.ID == int.Parse(TextBox1.Text) select s).First();
        db.MyTormisTabs.DeleteOnSubmit(st);
        db.SubmitChanges();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
        LoadData();
    }
}