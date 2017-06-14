using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Apply : System.Web.UI.Page
{

    A5service.ComAssistClient svc = new A5service.ComAssistClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        Fill_Dropdown();
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        int grantTypeKey = int.Parse(grantType.SelectedValue);
        string esp = explanation.Text;
        decimal amt = decimal.Parse(amount.Text);
        int userID = (int) Session["userKey"];
        svc.SubmitRequest(grantTypeKey, esp, amt, userID);

        //redirect to grant view page
        Response.Redirect("GrantView.aspx");

    }
    protected void Fill_Dropdown()
    {
        A5service.GrantType[] types = svc.GetGrantTypes();
        grantType.DataSource = types;
        grantType.DataValueField = "GrantTypeKey";
        grantType.DataTextField = "GrantTypeName";
        grantType.DataBind();
    }

}