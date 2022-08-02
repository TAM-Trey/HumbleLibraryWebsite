using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

public partial class SignIn : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Conn"]);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        OleDbDataAdapter db = new OleDbDataAdapter("Select * from [tbl_student] where [UName]='" + tbUName.Text + "' AND [ID_Number]='" + tbID.Text + "'", con);

        DataSet da = new DataSet();
        db.Fill(da);

        if (da.Tables[0].Rows.Count > 0)
        {
            Response.Redirect("Profile.aspx");
        }
        else
        {
            string script = "alert(\"Wrong Password! Try Again.\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
    protected void imgbtnHumble_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }
}