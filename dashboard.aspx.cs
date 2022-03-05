using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // ConnectionString="<%$ ConnectionStrings:DatabaseConnectionString1 %>" 
          //  DeleteCommand="DELETE FROM [info] WHERE [id] = @id" 
          //  InsertCommand="INSERT INTO [info] ([name], [email], [password]) VALUES (@name, @email, @password)" 
           // ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
           // SelectCommand="SELECT [id], [name], [email], [password] FROM [info]" 
           // UpdateCommand="UPDATE [info] SET [name] = @name, [email] = @email, [password] = @password WHERE [id] = @id">
        if(Session["email"] == null)
        {
            Response.Redirect("~/login.aspx");
        }
        else 
        {
            Literal1.Text="welcome " + Session["email"].ToString();
        }

    }
protected void  Button1_Click(object sender, EventArgs e)
{
    Session["email"]=null;
    Response.Redirect("~/login.aspx");
}
}
