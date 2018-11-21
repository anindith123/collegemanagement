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

public partial class View_Exam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // GetData();
            Class();
            if (Request.QueryString["Back"] != null)
            {
                DDLClass.ClearSelection();
                DDLClass.Items.FindByText(Session["C"].ToString().Trim()).Selected = true;
                GdVExam.PageIndex = int.Parse(Session["I"].ToString());
                GetData();
            }
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
        ExamBO Data = new ExamBO();
        DataSet ds = new DataSet();
        Data.Class = DDLClass.SelectedItem.Text;
        ds = Data.GetData();
        GdVExam.DataSource = ds;
        GdVExam.DataBind();
    }
    protected void GdVExam_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        ExamBO Data = new ExamBO();
        Data.EXMID = GdVExam.Rows[e.RowIndex].Cells[2].Text;
        int i = Data.DeleteExam();
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
    protected void GdVExam_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            string id = e.CommandArgument.ToString();
            if (DDLClass.SelectedIndex != 0)
            {
                Session["C"] = DDLClass.SelectedItem.Text;
                Session["I"] = GdVExam.PageIndex.ToString();
            }
            Response.Redirect("AddExamSchedule.aspx?Id=" + id);
        }
    }
    protected void GdVExam_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GdVExam.PageIndex = e.NewPageIndex;
        GetData();
    }
    protected void DDLClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
    }
}
