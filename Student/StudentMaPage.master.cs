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

public partial class Student_StudentMaPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserId"] != null)
        {
            if (!IsPostBack)
            {

                GetData();
                StudentName();
            }
        }
        else
        {
            Response.Redirect("~/Login/LoginPage.aspx");
        }
    }
    private void StudentName()
    {
        StudentBo Data = new StudentBo();
        Data.StundentID = Session["UserId"].ToString();
        DataSet ds = new DataSet();
        ds = Data.SelectData();
        //Session["FullName"] = ds.Tables[0].Rows[0]["FullName"].ToString();
        if (ds.Tables[0].Rows.Count > 0)
        {
            LblStudentName.Text = ds.Tables[0].Rows[0]["FullName"].ToString();
        }
        else
        {
            LblStudentName.Text = "Student";
        }


    }
    private void GetData()
    {
        NoticeBO Data = new NoticeBO();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GdVNotice.DataSource = ds;
        GdVNotice.DataBind();
    }
    protected void GdVNotice_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVNotice.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void Logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Login/LoginPage.aspx");
    }
}
