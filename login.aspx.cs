using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{

    A5service.ComAssistClient svc = new A5service.ComAssistClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        String password = passWord.Text;
        String username = userName.Text;
        int key = svc.Login(username, password);
        if(key != -1)
        {
            Session["userKey"] = key;
        }
        else
        {
            errorLabal.Text = "Invalid Login";
        }


    }
}