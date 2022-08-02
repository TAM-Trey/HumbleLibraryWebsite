using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{

    protected void btnSignIn0_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignIn.aspx");
    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {

        Response.Redirect("SignUp.aspx");
    }
    protected void btnHome0_Click(object sender, EventArgs e)
    {

        Response.Redirect("MainPage.aspx");
    }
    protected void btnLib_Click(object sender, EventArgs e)
    {

        Response.Redirect("Library.aspx");
    }
    protected void btnAbout_Click(object sender, EventArgs e)
    {

        Response.Redirect("About.aspx");
    }
}