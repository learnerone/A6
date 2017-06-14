using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        A5service.ComAssistClient svc = new A5service.ComAssistClient();
        bool result = svc.RegisterUser(lastNametxt.Text, firstNametxt.Text, emailtxt.Text,
            passwordtxt.Text, apartmenttxt.Text, streettxt.Text, citytxt.Text,
            statetxt.Text, zipCode.Text, homePhonetxt.Text, workPhonetxt.Text);
        if (result)
        {

            Response.Redirect("login.aspx");

        }
        else
        {

            resultlable.Text = "Something went terribly wrong";

        }

    }
}