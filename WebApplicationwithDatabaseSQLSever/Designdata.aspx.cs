using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationwithDatabaseSQLSever
{
    public partial class Designdata : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtcity.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.DataBind();
            Label1.Visible = true;
            Label1.Text = "Your Data Stored Successfully!";
            txtfname.Text = "";
            txtlname.Text = "";
            txtcity.Text = "";
            Label2.Visible = true;
            Label2.Text = "Entire Table Data is Here!";

        }
    }
}