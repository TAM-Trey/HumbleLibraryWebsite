using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Conn"]);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        
       

        if (tbNum.Text != "" || tbLName.Text != "" || tbMName.Text != "" || tbFName.Text != "" || tbAge.Text != "" || tbBday.Text != "" || tbCourse.Text != "" || tbYear.Text != "")
        {
            String usernamed = tbYear.Text + "-" + tbCourse.Text + "_" + tbLName.Text;

            con.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "Insert into tbl_student([ID_Number],[FNAme],[MName],[LName],[UName],[Age],[Birthday],[Course],[YearLvl]) values('" + tbNum.Text + "','" + tbFName.Text + "','" + tbMName.Text + "','" + tbLName.Text + "','" + usernamed + "','" + tbAge.Text + "','" + tbBday.Text + "','" + tbCourse.Text + "','" + tbYear.Text + "') ";
            command.ExecuteNonQuery();
            string script = "alert(\"Data Saved!\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            con.Close();
            
        }
        else
        {
            string script = "alert(\"Fill up everything!\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
    protected void imgbtnLogo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }
}