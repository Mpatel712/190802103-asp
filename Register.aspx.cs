using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO [info] ([name], [email], [password]) VALUES (@name, @email, @password)", con);
        cmd.Parameters.AddWithValue("@name",TextBox1.Text.Trim());
        cmd.Parameters.AddWithValue("@email", TextBox2.Text.Trim());
       
        cmd.Parameters.AddWithValue("@password", TextBox4.Text.Trim());
        con.Open();
        int s=cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            Session["email"] = TextBox1.Text;
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox4.Text = string.Empty;
            Response.Redirect("~/login.aspx");
        }
        else
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox4.Text = string.Empty;
            Literal1.Text = "Email and Password are invalid!";
        }
    }
}