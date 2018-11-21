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

public partial class Admin_Welcomepage : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Login/LoginPage.aspx");
            }
            GetData();
            Class();
        }

    }
    private void Class()
    {
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        DDLClass.DataSource = ds;
        DDLClass.DataTextField = "Class";
        DDLClass.DataValueField = "ClassID";
        DDLClass.DataBind();
    }
    private void GetData()
    {
       
        MSGBO Dataa = new MSGBO();
        DataSet ds1 = new DataSet();
        ds1 = Dataa.MSGGetData();
        
            GridView2.DataSource = ds1;
            GridView2.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        NoticeBO Data = new NoticeBO();
        Data.Title = TxtTitle.Text;
        Data.Description = TxtDescription.Text;
        if (RdBLNoticeFor.SelectedItem.Text == "WholeSchool")
        {
            Data.NoticeFor = RdBLNoticeFor.SelectedItem.Text;
        }
        else
        {
            Data.NoticeFor = RdBLNoticeFor.SelectedItem.Text;
            Data.Class = DDLClass.SelectedItem.Text;
        }
        int i = Data.InsertNotice();
        GetData();
        if (i > 1)
            {
                Page.RegisterStartupScript("kk", "<script>alert('Completed Successfully')</script>");
            }
            else
            {
                Page.RegisterStartupScript("ku", "<script>alert('Not Exists')</script>");
            }
            TxtTitle.Text = "";
            TxtDescription.Text = "";

        

    }

    protected void ChangePassword_Click(object sender, EventArgs e)
    {
        LoginBO Abo = new LoginBO();
        Abo.UserID = Session["UserId"].ToString();
        Abo.OldPassword = TxtOldPassword.Text;
        Abo.Password = TxtNewpassword.Text;
        int i = Abo.UpdatePassword();
         
        //string Pwd = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
        if (i>0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Password Change');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert('Password Not Change');</script>");
        }

    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GetData();

    }
    protected void RdBLNoticeFor_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RdBLNoticeFor.SelectedValue == "WholeSchool")
        {
            DDLClass.Visible = false;
        }
        else
        {
            DDLClass.Visible = true;
        }
    }
}
