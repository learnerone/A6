using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GrantView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }
    protected void View_Grant()
    {
        A5service.ComAssistClient svc = new A5service.ComAssistClient();
        A5service.GrantRequest[] gr =  svc.GetGrant((int)Session["userKey"]);
        grantList.DataSource = gr;
        grantList.DataBind();

    }
}