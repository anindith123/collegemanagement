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

public partial class Admin_ViewSubjects : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
        }
    }
    private void GetData()
    {
        ClassBo Data = new ClassBo();
        DataSet ds = new DataSet();
        ds = Data.GetData();
        GdVClass.DataSource = ds;
        GdVClass.DataBind();
    }
    protected void GdVClass_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVClass.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void GdVClass_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("AddSubject.aspx?Id=" + id);
        }
    }
    protected void GdVClass_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        ClassBo Data = new ClassBo();
        Data.ClassID = GdVClass.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.Delete();
        if (i > 0)
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Deleted Successfully');</script>");
        }
        else
        {
            Page.RegisterStartupScript("SS", "<script> alert(' Not Deleted ');</script>");
        }
        GetData();
    }
}
