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

public partial class Admin_ForgetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            LoginBO Data = new LoginBO();
            string u = Txt_UserName.Text;
            Data.UserID = u.ToString();
            DataSet ds = new DataSet();
            ds = Data.AdminLogin();
            if (ds.Tables[0].Rows.ToString() != null)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string u1 = ds.Tables[0].Rows[i]["UserID"].ToString();
                    string p1 = ds.Tables[0].Rows[i]["Password"].ToString();
                    
                    if (u == u1)
                    {
                        //SendMail(u1, Email, p1);
                        //Page.RegisterStartupScript("ss", "<script>alert('Hello "+u1 +" Your Password is "+p1+"')</script>");
                        lblMessage.Text = "Hello " + u1 + " Your Password is " + p1;
                    }
                   
                }

            }
            else
            {
                //Page.RegisterStartupScript("ss", "<script>alert('Invalid UserName')</script>");
                lblMessage.Text = "Please Check Your UserName ";
            }

        }
        catch
        { }

    }
}
