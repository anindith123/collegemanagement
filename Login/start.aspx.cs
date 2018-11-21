using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Admin_LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    LoginBO Data = new LoginBO();
    DataSet ds = new DataSet();
   
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        Data.UserID = TxtUserID.Text;
        Data.Password = TxtPassword.Text;
        ds = Data.GetData();
        string UserType = string.Empty;
        if (ds.Tables[0].Rows.Count > 0)
        {
            UserType = ds.Tables[0].Rows[0]["UserType"].ToString();

            if (UserType != null)
            {

                if (UserType == "Admin")
                {
                    Session["Userid"] = TxtUserID.Text;
                    Response.Redirect("~/Admin/Welcomepage.aspx");
                }
                else if (UserType == "Teacher")
                {
                    Session["Userid"] = TxtUserID.Text;
                    Response.Redirect("~/Teacher/WelcomePage.aspx");
                }
                else if (UserType == "Student")
                {
                    Session["Userid"] = TxtUserID.Text;
                    Response.Redirect("~/Student/WelcomePage.aspx");
                }
            }
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert('UserID and Password Invalid');</script>");
        }

    }
}
