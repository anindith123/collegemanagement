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

public partial class Teacher_WelcomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login/LoginPage.aspx");
            }
            GetData();
        }

    }
    private void GetData()
    {
        MSGBO Dataa = new MSGBO();
        Dataa.UserID = Session["UserId"].ToString();
        DataSet ds1 = new DataSet();
        ds1 = Dataa.MSGGetTEach();
        if (ds1.Tables[0].Rows.Count > 0)
        {
            GridView2.DataSource = ds1;
            GridView2.DataBind();
            LblMSG.Visible = false;
        }
        else
        {
            LblMSG.Visible = true;
            LblMSG.Text = "No Data Found";

        }
    }


    protected void ChangePassword_Click(object sender, EventArgs e)
    {
        LoginBO Abo = new LoginBO();
        Abo.UserID = Session["UserId"].ToString();
        Abo.OldPassword = TxtOldPassword.Text;
        Abo.Password = TxtNewpassword.Text;
        int i = Abo.UpdatePassword();

        //string Pwd = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Password Change');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert('Old Password Not Correct');</script>");
        }
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GetData();
    }
}
